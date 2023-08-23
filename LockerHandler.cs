namespace RewrittedAirPortLockerRental
{
    public static class LockerHandler
    {

        public static void ViewLocker(Locker[] lockers, int min, int max)
        {

            int lockerIndex = Prompter.GetRequiredRangeMinusOne("Enter locker number (1-100): ", min, max);

            Console.Write($"Locker {lockers[lockerIndex].LockerNumber} ");
            Console.Write($"contents: {lockers[lockerIndex].Content}, ");
            if(lockers[lockerIndex].IsEmpty){
                Console.WriteLine($"no one is renting this locker.");
            }
            else
            { 
            Console.WriteLine($"renter: {lockers[lockerIndex].Renter}.");
            }
        }
        public static void RentLocker(Locker[] lockers, int min, int max)
        {
            int lockerIndex = Prompter.GetRequiredRangeMinusOne("Enter locker number (1-100): ", min, max);
            string content = Prompter.GetRequiredString("Enter the item you want to store in the locker: ");
            string renter = Prompter.GetRequiredString("Enter the name of the person renting the locker: ");
            if (lockers[lockerIndex].IsEmpty)
            {
                lockers[lockerIndex].Content = content;
                lockers[lockerIndex].Renter = renter;
                lockers[lockerIndex].IsEmpty = false;
                Console.WriteLine($"Locker {lockers[lockerIndex].LockerNumber} has been rented by {lockers[lockerIndex].Renter}, for {content} storage.");
            }
            else
            {
                Console.WriteLine($"Sorry, but locker {lockers[lockerIndex].LockerNumber} has already been rented!");
            }
        }
        public static void EndLockerRental(Locker[] lockers, int min, int max)
        {
            int lockerIndex = Prompter.GetRequiredRangeMinusOne("Enter locker number (1-100): ", min, max);
            if (lockers[lockerIndex].IsEmpty)
            {
                Console.WriteLine($"Locker {lockers[lockerIndex].LockerNumber} is not currently rented.");
            }
            else
            {
                Console.WriteLine($"Locker {lockers[lockerIndex].LockerNumber} rental has ended, please take your {lockers[lockerIndex].Content}.");
                lockers[lockerIndex].Content = "is EMPTY";
                lockers[lockerIndex].Renter = "";
                lockers[lockerIndex].IsEmpty = true;
            }
        }

        public static void ListLockerContents(Locker[] lockers)
        {
            for (int i = 0; i < lockers.Length; i++)
            {
                if (!lockers[i].IsEmpty)
                {
                    Console.WriteLine($"Locker {lockers[i].LockerNumber}: {lockers[i].Content}");
                }
            }

        }
    }
}
