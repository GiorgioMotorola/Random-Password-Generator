using System.Text;

namespace RandomPasswordGenerator
{
    class RandomPasswordGenerator
    {
        private const string CapitalLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
        private const string LowercaseLetters = "qwertyuiopasdfghjklzxcvbnm";
        private const string Digits = "1234567890";
        private const string SpecialCharacters = "!@#$%^&*()-_=+<>,.?/|";
        private const string AllChars = CapitalLetters + LowercaseLetters + Digits + SpecialCharacters;

        private static Random rand = new Random();
        static void Main()
        {
            StringBuilder password = new StringBuilder();
            for (int i = 1; i <= 2; i++)
            {
                char CapitalLetter = GenerateChar(CapitalLetters);
                InstertAtRandomPositions(password, CapitalLetter);

            }
            for (int i = 1; i <= 2; i++)
            {
                char LowercaseLetter = GenerateChar(LowercaseLetters);
                InstertAtRandomPositions(password, LowercaseLetter);
            }
                char digit = GenerateChar(Digits);
                InstertAtRandomPositions(password, digit);

            for (int i = 0;i < 3; i++)
            {
                char specialChar = GenerateChar(SpecialCharacters);
                InstertAtRandomPositions(password, specialChar);
            }
            int count = rand.Next(8);
            for (int i = 0;i <= count;i++)
            {
                char specialChar = GenerateChar(AllChars);
                InstertAtRandomPositions(password, specialChar);
            }


            Console.WriteLine("---------------------Your New Password is---------------------");
            Console.WriteLine(" ");
            Console.WriteLine("                         " + password);
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------------------------");


        }
        private static void InstertAtRandomPositions(StringBuilder password, char character)
        {
            int randomPosition = rand.Next(password.Length + 1);
            password.Insert(randomPosition, character);
        }
        private static char GenerateChar(string availableChars)
        {
            int randomIndex = rand.Next(availableChars.Length);
            char randomChar = availableChars[randomIndex];
            return randomChar;
        }
    }
}