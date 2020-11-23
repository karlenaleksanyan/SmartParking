using SmartParking.Enums;
using SmartParking.Parking;
using SmartParking.Smart;
using System;

namespace SmartParking
{
 class ParkingManager
    {
        /// <summary>
        /// Information of the car ordered
        /// </summary>
        private static Car _yourCar;

        /// <summary>
        /// Description of the park
        /// </summary>
        public static Park _parking;

        /// <summary>
        /// total rent
        /// </summary>
        private static Wallet _wallet;

        /// <summary>
        /// Camera drawn car informations
        /// </summary>
        private static Camera _camera;

        /// <summary>
        /// From Constructor creat Park carta
        /// </summary>
        public ParkingManager()
        {
            _parking = new Park();
        }

        
        /// <summary>
        ///  This functions we geting client car informations
        /// </summary>
        /// <param name="brand">client car brand</param>
        /// <param name="number">client car license plates</param>
        /// <param name="color">client car color</param>
        public static void ClieantCar(BrandsCar brand, string number, ConsoleColor color)
        {
            Console.WriteLine("\t-------See the clients-------\n");
            _yourCar = new Car(brand, number, color);
            Table();
        }

        /// <summary>
        /// Write Prk Tabloo, free and buys space
        /// </summary>
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


        /// <summary>
        ///This functions we geting park incoming car informations
        /// </summary>
        /// <param name="open">input time to enter the garage</param>
        /// <param name="close">input time to go  to park</param>
        /// <param name="brand">input car brand</param>
        /// <param name="number">input car number</param>
        /// <param name="color">input car color</param>
        public static void InformationParkIncomingCar(DateTime open, DateTime close,
                                     BrandsCar brand, string number, ConsoleColor color)
        {
            Console.WriteLine("\t-------See the security guards-------\n");
            Camera(open, close, brand, number, color);

            _wallet = new Wallet();
            Console.WriteLine(_wallet);
        }

        /// <summary>
        /// Camera of the Park
        /// </summary>
        /// <param name="open">nput time to enter the garage</param>
        /// <param name="close">input time to go  to park</param>
        /// <param name="brand">input car brand</param>
        /// <param name="number">input car number</param>
        /// <param name="color">input car color</param>
        private static void Camera(DateTime open, DateTime close,
                                       BrandsCar brand, string number, ConsoleColor color)
        {

          
            
                _camera = new Camera(open, close, brand, number, color);
                _camera.Security(_camera, _yourCar);
                Console.WriteLine(_camera);
            
            
        }
    }
}
