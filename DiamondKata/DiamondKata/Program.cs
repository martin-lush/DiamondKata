namespace DiamondKata
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            char character = GetCharacterFromInput(args.FirstOrDefault());

            while(character is default(char))
            {
                Console.Write("Please enter a character: ");
                character = GetCharacterFromInput(Console.ReadLine());
            }

            string result = Diamond.PrintDiamond(character);
            Console.WriteLine(result);
        }

        private static char GetCharacterFromInput(string input)
        {
            _ = char.TryParse(input, out char character);
            return character;
        }
    }
}