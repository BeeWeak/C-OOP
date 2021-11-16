namespace BetterOOPDemo
{
    public class Truck : LandVehicle, IRental
    {
        public TruckType Style { get; set; }
        public int RentalID { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
