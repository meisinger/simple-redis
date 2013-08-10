using System;
using System.IO;
using System.Text;

namespace Simple.Redis.Utilities
{
    internal class RedisReader
    {
        private readonly StringBuilder buffer;
        private readonly Stream stream;

        internal RedisReader(Stream stream)
        {
            this.stream = stream;
            buffer = new StringBuilder();
        }

        internal RedisResult Parse()
        {
            char indicator;
            var line = ParseLine(out indicator);

            if (indicator.Equals('-'))
                throw new Exception(line);

            var container = new RedisResultBuffer();
            switch (indicator)
            {
                case '$':
                    ParseBulkReply(container, line);
                    break;
                case '*':
                    ParseMultiBulkReply(container, line);
                    break;
                case ':':
                    container.AddRecord(line);
                    break;
                case '+':
                    container.AddRecord(line);
                    break;
                default:
                    var message = string.Format(
                        "Unexpected indicator detected. Indicator \"{0}\" is not supported.", 
                            indicator);

                    throw new InvalidDataException(message);
                    break;
            }

            return container.ToResult();
        }

        private void ParseBulkReply(RedisResultBuffer container, string line)
        {
            int length;
            if (!int.TryParse(line, out length))
            {
                var error = string.Format("Expected Bulk Reply to indicate stream length. Received [{0}].", line);
                throw new InvalidDataException(error);
            }

            if (length.Equals(-1))
            {
                container.AddEmptyRecord();
                return;
            }

            var value = ParseLineExact(length);
            container.AddRecord(value);
        }

        private void ParseMultiBulkReply(RedisResultBuffer container, string line)
        {
            int count;
            if (!int.TryParse(line, out count))
            {
                var error = string.Format("Expected Multi Bulk Reply to indicate result count. Received [{0}].", line);
                throw new InvalidDataException(error);
            }

            for (int index = 0; index < count; index++)
            {
                char indicator;
                var multiLine = ParseLine(out indicator);

                if (!indicator.Equals(':') && !indicator.Equals('$'))
                {
                    container.AddEmptyRecord(index);
                    continue;
                }

                if (indicator.Equals(':'))
                {
                    container.AddRecord(index, multiLine);
                    continue;
                }

                int length;
                if (!int.TryParse(multiLine, out length))
                {
                    container.AddEmptyRecord(index);
                    continue;
                }

                if (length.Equals(-1))
                {
                    container.AddEmptyRecord(index);
                    continue;
                }

                var value = ParseLineExact(length);
                container.AddRecord(index, value);
            }
        }

        private string ParseLine()
        {
            buffer.Length = 0;

            int character;
            while ((character = stream.ReadByte()) != -1)
            {
                if (character.Equals(13))
                    continue;
                if (character.Equals(10))
                    break;

                buffer.Append((char)character);
            }

            return buffer.ToString();
        }

        private string ParseLine(out char indicator)
        {
            var line = ParseLine();

            if (string.IsNullOrEmpty(line))
            {
                indicator = '?';
                return string.Empty;
            }

            indicator = line[0];
            return line.Substring(1);
        }

        private string ParseLineExact(int length)
        {
            var bytes = new byte[length];
            var consumed = 0;

            do
            {
                var read = stream.Read(bytes, consumed, (length - consumed));
                if (read < 1)
                    throw new EndOfStreamException();

                consumed += read;
            } while (consumed < length);

            if (stream.ReadByte() != 13 || stream.ReadByte() != 10)
                throw new InvalidOperationException();

            return Encoding.UTF8.GetString(bytes);
        }
    }
}
