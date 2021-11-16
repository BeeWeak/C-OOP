namespace BetterOOPDemo
{
    public interface IRental
    {
        int RentalID { get; set; }
        string CurrentRenter { get; set; }
        decimal PricePerDay { get; set; }
    }
}
