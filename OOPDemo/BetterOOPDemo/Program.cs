using System;
using System.Collections.Generic;

namespace BetterOOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRental> rentals = new List<IRental>();

            rentals.Add(new Truck() { CurrentRenter = "Truck renter" });
            rentals.Add(new Sailboat() { CurrentRenter = "Sailboat renter" });
            rentals.Add(new Car() { CurrentRenter = "Car renter" });

            foreach(var r in rentals)
            {
                if (r is Truck t)
                {
                    t.Style = TruckType.LongBed;
                }
                Console.WriteLine(r.RentalID);
                Console.WriteLine(r.CurrentRenter);
                Console.WriteLine(r.PricePerDay);
            }


        }
    }
}
