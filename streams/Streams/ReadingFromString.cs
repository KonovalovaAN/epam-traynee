namespace Streams
{
    public static class ReadingFromString
    {
        public static string ReadAllStreamContent(StringReader stringReader)
        {
            return stringReader.ReadToEnd();
        }

        public static string ReadCurrentLine(StringReader stringReader)
        {
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
            return stringReader.ReadLine();
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        }

        public static bool ReadNextCharacter(StringReader stringReader, out char currentChar)
        {
            int sr = stringReader.Read();
            if (sr == -1)
            {
                currentChar = ' ';
                return false;
            }
            else
            {
                currentChar = (char)sr;
                return true;
            }
        }

        public static bool PeekNextCharacter(StringReader stringReader, out char currentChar)
        {
            if (stringReader.Peek() == -1)
            {
                currentChar = ' ';
                return false;
            }
            else
            {
                currentChar = (char)stringReader.Peek();
                return true;
            }
        }

        public static char[] ReadCharactersToBuffer(StringReader stringReader, int count)
        {
            char[] readCharacterToBuffer = new char[count];
            for (int i = 0; i < count; i++)
            {
                readCharacterToBuffer[i] = (char)stringReader.Read();
            }

            return readCharacterToBuffer;
        }
    }
}
