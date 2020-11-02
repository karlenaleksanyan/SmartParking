﻿using Microsoft.VisualBasic.CompilerServices;
using SmartParking.Enums;
using System;

namespace SmartParking.Smart
{
    class Camera : MyCar
    {
        public static DateTime openData;

        public static DateTime closeData;

        public string cameraNumber;

        public ConsoleColor carmeraColor;

        public BrandsCar cameraBrand;



        public void Security(Camera camera, MyCar myCar)
        {
            if (myCar == camera)
            {
                Console.WriteLine("Everything is OK");
            }
            else
            {
                throw new Exception("Wrong Car");
            }
        }
        public Camera() { }

        public Camera(DateTime openData, DateTime closeData,
                               BrandsCar carBrand, string numberCar, ConsoleColor color)
                                                            : base(carBrand, numberCar, color)
        {
            Camera.openData = openData;
            Camera.closeData = closeData;
            this.cameraNumber = numberCar;
            this.carmeraColor = color;
            this.cameraBrand = carBrand;
        }
        public override string ToString()
        {
            return $"Camera watch\n" +
                $"\tOpen data  {openData}\n" +
                $"\tClose data  {closeData}\n" +
                $"\tCar number  {cameraNumber}\n" +
                $"\tColor car {carmeraColor}\n" +
                $"\tBrand car {cameraBrand}\n";
        }

        public override bool Equals(object obj)
        {
            return obj is Camera camera &&
                   base.Equals(obj) &&
                   carBrand == camera.carBrand &&
                   numberCar == camera.numberCar &&
                   color == camera.color &&
                   cameraNumber == camera.cameraNumber &&
                   carmeraColor == camera.carmeraColor &&
                   cameraBrand == camera.cameraBrand;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(MyCar myCar, Camera camera)
        {
            return myCar.carBrand == camera.cameraBrand &&
                   myCar.color == camera.carmeraColor &&
                   myCar.numberCar == camera.cameraNumber;
        }

        public static bool operator !=(MyCar myCar, Camera camera)
        {
            return myCar.carBrand != camera.cameraBrand ||
                   myCar.color != camera.carmeraColor ||
                   myCar.numberCar != camera.cameraNumber;
        }
    }
}
