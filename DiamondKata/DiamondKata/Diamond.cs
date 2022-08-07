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
                throw new NotImplementedException();
            }
        }

        public string GetFirstOrLastLine(char character)
        {
            var characterIndex = Array.IndexOf(Alphabet, character);
            var requiredSpaces = characterIndex;

            var whitespaces = new string(Enumerable.Repeat(' ', requiredSpaces).ToArray());
            return $"{whitespaces}{Alphabet[0]}{whitespaces}";
        }

        public string GetMiddleLine(char character)
        {
            var charIndex = Array.IndexOf(Alphabet, character); 
            var requiredSpaces = (charIndex * 2) - 1;

            var whitespaces = new string(Enumerable.Repeat(' ', requiredSpaces).ToArray());
            return $"{character}{whitespaces}{character}";
        }

        public IReadOnlyList<string> GetDiamondTop(char character)
        {
            var characterIndex = Array.IndexOf(Alphabet, character);

            var diamondTop = new List<string>();

            for (var i = 1; i < characterIndex; i++)
            {
                var whitespacesBeforeAndAfter = new string(Enumerable.Repeat(' ', characterIndex - i).ToArray());
                var whitespacesInBetween = new string(Enumerable.Repeat(' ', (i * 2) - 1).ToArray());
                diamondTop.Add(
                    $"{whitespacesBeforeAndAfter}{Alphabet[i]}{whitespacesInBetween}{Alphabet[i]}{whitespacesBeforeAndAfter}");
            }

            return diamondTop;
        }
    }
}
