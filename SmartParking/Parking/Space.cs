﻿namespace SmartParking.Parking
{
    class Space : Park
    {
        public byte lenght = 8;

        public byte width = 3;

        public Space()
        {
            busySpaceCaunt++;
        }

        public override string ToString()
        {
            return $"Space\n" +
                $"\tLenght {lenght} metrs\n" +
                $"\tWidth {width} metrs\n";
        }
    }
}
