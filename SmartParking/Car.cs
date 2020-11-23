using SmartParking.Enums;
using SmartParking.Parking;
using System;

namespace SmartParking
{
class Car
    {
        public BrandsCar carBrand;

        public string numberCar;

        public ConsoleColor color;


        public Car() { }

        public Car(BrandsCar carBrand, string numberCar, ConsoleColor color)
        {
            this.carBrand = carBrand;
            this.numberCar = numberCar;
            this.color = color;
        }

        public override string ToString()
        {
            return $"My car \n" +
                        $"\tBrand - {carBrand}\n" +
                       $"\tNumber - {numberCar}\n" +
                       $"\tColor - {color}\n";
        }

        public override bool Equals(object obj)
        {
            return obj is Car car &&
                      numberCar == car.numberCar &&
                      carBrand == car.carBrand &&
                      color == car.color;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
