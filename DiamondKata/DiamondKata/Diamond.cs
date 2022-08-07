﻿namespace DiamondKata
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

        public string GetMiddleLine(char character)
        {
            var charIndex = Array.IndexOf(Alphabet, character); 
            var requiredSpaces = (charIndex * 2) - 1;

            var whitespaces = new string(Enumerable.Repeat(' ', requiredSpaces).ToArray());
            return $"{character}{whitespaces}{character}";
        }
    }
}
