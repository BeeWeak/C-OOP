namespace BetterOOPDemo
{
    public class Sailboat : IRental
    {
        public int RentalID { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
