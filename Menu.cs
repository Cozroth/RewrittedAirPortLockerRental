namespace RewrittedAirPortLockerRental
{
    public static class Menu
    {
        /// <summary>
        /// Start by creating an array of lockers with the amount specified by the user, then starts the software by showing the menu and handling menu choices.
        /// </summary>
        /// <param name="amount">positive int value for the amount of Locket Objects the user want to create.</param>
        public static void Start()
        {
            int amount = Prompter.GetRequiredPositiveInt("Enter the amount of lockers the airport have: ");
            Locker[] lockers = MultipleObjectCreator.InitializeMultipleObjects(amount);
            Menu.MenuAction("Enter your choice (1-5): ", 1, 5, lockers);
        }
     /// <summary>
     /// Clears the console then writes out the menu choices for the user.
     /// </summary>
        public static void MenuWriter()
        {
            Console.Clear();
            Console.WriteLine("Airport Locker Rental Menu");
            Console.WriteLine("=============================");
            Console.WriteLine("1. View a locker");
            Console.WriteLine("2. Rent a locker");
            Console.WriteLine("3. End a locker rental");
            Console.WriteLine("4. List of all locker contents");
            Console.WriteLine("5. Quit");
        }

        /// <summary>
        /// Makes sure the user gives a valid menu choice and handles the menu options.
        /// </summary>
        /// <param name="prompt">The question you want validated from the user.</param>
        /// <param name="minMenu">lowest value in the range of menu choices.</param>
        /// <param name="maxMenu">highest value in the range of menu choices.</param>
        /// <param name="lockers">Array of Locker[] lockers.</param>
        public static void MenuAction(string prompt, int minMenu, int maxMenu, Locker[] lockers)
        {
            int menu;
            do
            {
                MenuWriter();
                menu = Prompter.GetRequiredRange(prompt, minMenu, maxMenu);

                switch (menu)
                {
                    case 1:
                        LockerHandler.ViewLocker(lockers, 0, lockers.Length);
                        break;
                    case 2:
                        LockerHandler.RentLocker(lockers, 0, lockers.Length);
                        break;
                    case 3:
                        LockerHandler.EndLockerRental(lockers, 0, lockers.Length);
                        break;
                    case 4:
                        LockerHandler.ListLockerContents(lockers);
                        break;
                    case 5:
                        return;
                }
                Any();
            } while (menu != 5);
        }

        public static void Any()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
