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
            if(Array.IndexOf(Alphabet, character) == -1)
            {
                throw new ArgumentOutOfRangeException(nameof(character), "Not found within the specifed alphabet");
            }

            return character.ToString();
        }
    }
}
