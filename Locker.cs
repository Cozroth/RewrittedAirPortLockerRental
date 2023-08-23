namespace RewrittedAirPortLockerRental
{
    public class Locker
    {
        private int _lockerNmbr;
        private string _content;
        private bool _empty;
        private string _renter;

        public string Content
        {
            get { return _content; }
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    _content = "is empty";
                }
                else
                {
                    _content = value;
                    _empty = false;
                }
            }
        }
        public int LockerNumber
        {
            get { return _lockerNmbr; }
            set { _lockerNmbr = value; }
        }
        public bool IsEmpty
        {
            get { return _empty; }
            set { _empty = value; }
        }
        public string Renter
        {
            get{ return _renter; }
            set{ _renter = value; }
        }
    }
}