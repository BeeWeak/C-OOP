namespace BetterOOPDemo
{
    public class Car : LandVehicle, IRental
    {
        public CarType Style { get; set; }


        public int RentalID { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
