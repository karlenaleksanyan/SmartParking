using SmartParking.Enums;
using SmartParking.Parking;
using SmartParking.Smart;
using System;

namespace SmartParking
{
    static class SmartParking
    {
        private static MyCar _yourCar;

        private static Park _parking = new Park();

        private static Wallet _wallet;

        private static Camera _camera;

        private static Account _account;

        //user
        public static void MyCar_User(BrandsCar brand, string number, ConsoleColor color)
        {
            Console.WriteLine("\t-------User account-------\n");
            _yourCar = new MyCar(brand, number, color);
            Table();
        }

        private static void Table()
        {
            Console.WriteLine("\tPrking Table");
            Park.Tabloo();
            Console.WriteLine("Write your can fee space");
            Console.Write("\twrite this row ");
            int row = int.Parse(Console.ReadLine());
            Console.Write($"\twrite this column");
            int column = int.Parse(Console.ReadLine());
            _parking[row - 1, column - 1] = new Space();
        }


        //admin
        public static void CarEnterToPark_Admin(DateTime open, DateTime close,
                                     BrandsCar brand, string number, ConsoleColor color)
        {
            Console.WriteLine("\t-------Admin account-------\n");
            Camera(Account.admin, open, close, brand, number, color);

            _wallet = new Wallet();
            Console.WriteLine(_wallet);
        }

        private static void Camera(Account account, DateTime open, DateTime close,
                                       BrandsCar brand, string number, ConsoleColor color)
        {
            _account = account;
            if (_account == Account.admin)
            {
                _camera = new Camera(open, close, brand, number, color);
                _camera.Security(_camera, _yourCar);
                Console.WriteLine(_camera);
            }
            else
            {
                throw new Exception("This Function not available");
            }
        }
    }
}
