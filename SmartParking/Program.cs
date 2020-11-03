using SmartParking.Enums;
using System;

namespace SmartParking
{
    class Program
    {
        static void Main(string[] args)
        {
            //user
            SmartParking.MyCar_User(BrandsCar.BMW, "22zz222", ConsoleColor.Black);

            SmartParking.MyCar_User(BrandsCar.Lexus, "23oo110", ConsoleColor.Green);

            SmartParking.MyCar_User(BrandsCar.Lexus, "23oo110", ConsoleColor.Green);

            SmartParking.MyCar_User(BrandsCar.Lexus, "23oo110", ConsoleColor.Green);

            //admin
            SmartParking.CarEnterToPark_Admin(Account.admin, DateTime.Parse("6:15"), DateTime.Parse("10:14"),
                                         BrandsCar.Lexus, "23oo110", ConsoleColor.Green);

        }
    }
}
