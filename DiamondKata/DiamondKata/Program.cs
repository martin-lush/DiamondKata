namespace DiamondKata
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            char character = GetCharacterFromInput(args.FirstOrDefault());

            while(character is default(char))
            {
                Console.Write("Please enter a character (A-Z): ");
                character = GetCharacterFromInput(Console.ReadLine());
            }

            try
            {
                string result = new Diamond().PrintDiamond(character);
                Console.WriteLine(result);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static char GetCharacterFromInput(string? input)
        {
            _ = char.TryParse(input, out char character);
            return character;
        }
    }
}