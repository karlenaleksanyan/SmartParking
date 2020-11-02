using SmartParking.Enums;
using System;

namespace SmartParking.Smart
{
	abstract class Camera:MyCar
	{
		public DateTime OpenData = DateTime.Parse("h:mm tt");

		public DateTime CloseData = DateTime.Parse("h:mm tt");

		public BrandsCar cameraBrand;

		public string cameraNumber;

		public ConsoleColor carmeraColor;

		public Camera(BrandsCar cameraBrand, string cameraNumber, ConsoleColor cameraColor,
			                       BrandsCar  carBrand, string numberCar, ConsoleColor color)
				                                     :base(carBrand, numberCar,color)
		{
			this.cameraBrand = cameraBrand;
			this.cameraNumber = cameraNumber;
			this.carmeraColor = cameraColor;
			if (Security())
			{
				Console.WriteLine("Everything is OK");
			}
			else
			{
				throw new Exception("Wrong Car");
			}

		}

		public bool Security()
		{
			return cameraBrand==carBrand &&
				    cameraNumber==numberCar &&
					 carmeraColor==color;
		}
		
		public Camera() 
		{

		}

	}
}
