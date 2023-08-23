namespace RewrittedAirPortLockerRental
{
    public static class Prompter
    {
        public static string GetRequiredString(string prompt)
        {
            string validString;
            do
            {
                Console.Write(prompt);
                validString = Console.ReadLine();
                if (!string.IsNullOrEmpty(validString.Trim()))
                {
                    return validString;
                }

                Console.WriteLine("You must enter atleast one character.");
                
            } while (true);
        }
        public static int GetRequiredRange(string prompt, int min, int max)
        {
            int validRange;
            do
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out validRange))
                {
                    if (validRange >= min && validRange <= max)
                    {
                        return validRange;
                    }
                }
                Console.WriteLine($"You must enter a numerical value in the range of {min} and {max}.");

            } while (true);
        }

        public static int GetRequiredRangeMinusOne(string prompt, int min, int max) {
            int validRange;
            do
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out validRange))
                {
                    if (validRange >= min && validRange <= max)
                    {
                        return validRange - 1;
                    }
                }
                Console.WriteLine($"You must enter a numerical value in the range of {min} and {max}.");

            } while (true);
        }
        public static int GetRequiredPositiveInt(string prompt)
        {
            int validInt;
            do
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out validInt))
                {
                    if (validInt > 0)
                    {
                        return validInt;
                    }
                }

                Console.WriteLine("You must enter a positive number.");

            } while (true);
        }

    }
}
