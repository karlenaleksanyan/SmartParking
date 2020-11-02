using SmartParking.Enums;
using SmartParking.Parking;
using SmartParking.Smart;
using System;

namespace SmartParking
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCar myCar1 = new MyCar(BrandsCar.BMW, "22zz222", ConsoleColor.Black);
            MyCar myCar2 = new MyCar(BrandsCar.Lexus, "23oo110", ConsoleColor.Green);
            Console.WriteLine(myCar1);

            Park parking = new Park();

            parking[2, 3] = new Space();
            parking[3, 4] = new Space();

            Console.WriteLine(parking);

            Camera camera = new Camera(DateTime.Parse("6:15"), DateTime.Parse("8:14"),
                                        BrandsCar.Lexus, "23oo110", ConsoleColor.Green);
            Console.WriteLine(camera);
            Console.WriteLine(camera);

            Wallet wallet = new Wallet();
            Console.WriteLine(wallet);

            camera.Security(camera, myCar2);
        }
    }
}
