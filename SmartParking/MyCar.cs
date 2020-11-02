using SmartParking.Enums;
using System;

namespace SmartParking
{
	class MyCar
	{
		public readonly BrandsCar carBrand;

		public readonly string numberCar;

		public readonly ConsoleColor color;

		public MyCar()
		{

		}

		public MyCar(BrandsCar carBrand, string numberCar, ConsoleColor color)
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
			return obj is MyCar car &&
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
