using SmartParking.Enums;
using SmartParking.Parking;
using System;

namespace SmartParking
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingManager manager = new ParkingManager();


            ParkingManager.ClieantCar(BrandsCar.BMW, "22zz222", ConsoleColor.Black);

            ParkingManager.ClieantCar(BrandsCar.Lexus, "23oo110", ConsoleColor.Green);

            ParkingManager.ClieantCar(BrandsCar.Audi, "23oo110", ConsoleColor.Green);

            ParkingManager.ClieantCar(BrandsCar.Lexus, "23oo110", ConsoleColor.Green);

            
            ParkingManager.InformationParkIncomingCar(DateTime.Parse("6:15"), DateTime.Parse("10:14"),
                                         BrandsCar.Lexus, "23oo110", ConsoleColor.Green);
            

        }
    }
}
