using System.Text;

namespace DiamondKata
{
    public class Diamond
    {
        public char[] Alphabet { get; private set; }

        public Diamond(char[]? alphabet = null)
        {
            if(alphabet == null)
            {
                Alphabet = Settings.Alphabet.UpperEnglishAlphabet;
            }
            else if(alphabet.Length == 0)
            {
                throw new ArgumentException("Alphabet must have a sequence", nameof(alphabet));
            }
            else
            {
                Alphabet = alphabet;
            }
        }

        public string PrintDiamond(char character)
        {
            var characterIndex = Array.IndexOf(Alphabet, character);
            if (characterIndex == -1)
            {
                throw new ArgumentOutOfRangeException(nameof(character), "Not found within the specifed alphabet");
            }
            else if (characterIndex == 0)
            {
                return character.ToString();
            }
            else
            {
                var builder = new StringBuilder();
                builder.AppendLine(GetFirstOrLastLine(character));
                foreach(string line in GetDiamondTop(character))
                {
                    builder.AppendLine(line);
                }
                builder.AppendLine(GetMiddleLine(character));
                foreach (string line in GetDiamondTop(character).Reverse())
                {
                    builder.AppendLine(line);
                }
                builder.Append(GetFirstOrLastLine(character));

                return builder.ToString();
            }
        }

        public string GetFirstOrLastLine(char character)
        {
            var characterIndex = Array.IndexOf(Alphabet, character);
            var requiredSpaces = characterIndex;

            var whitespaces = GetWhitespaces(requiredSpaces);
            return $"{whitespaces}{Alphabet[0]}{whitespaces}";
        }

        public string GetMiddleLine(char character)
        {
            var charIndex = Array.IndexOf(Alphabet, character); 
            var requiredSpaces = (charIndex * 2) - 1;

            var whitespaces = GetWhitespaces(requiredSpaces);
            return $"{character}{whitespaces}{character}";
        }

        public IReadOnlyList<string> GetDiamondTop(char character)
        {
            var characterIndex = Array.IndexOf(Alphabet, character);

            var diamondTop = new List<string>();

            for (var i = 1; i < characterIndex; i++)
            {
                var whitespacesBeforeAndAfter = GetWhitespaces(characterIndex - i);
                var whitespacesInBetween = GetWhitespaces((i * 2) - 1);
                diamondTop.Add(
                    $"{whitespacesBeforeAndAfter}{Alphabet[i]}{whitespacesInBetween}{Alphabet[i]}{whitespacesBeforeAndAfter}");
            }

            return diamondTop;
        }

        private static string GetWhitespaces(int count)
        {
            return new string(' ', count);
        }
    }
}
