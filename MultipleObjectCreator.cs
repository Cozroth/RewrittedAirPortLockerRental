namespace RewrittedAirPortLockerRental
{
    public static class MultipleObjectCreator
    {
        public static Locker[] InitializeMultipleObjects(int amount)
        {

            Locker[] lockers = new Locker[amount];
            for (int i = 0; i < lockers.Length; i++)
            {
                lockers[i] = new Locker
                {
                    LockerNumber = i + 1,
                    Content = "is empty",
                    IsEmpty = true,
                    Renter = ""
                };
            }
            return lockers;
        }
    }
}
