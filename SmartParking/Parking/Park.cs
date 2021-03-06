﻿using System;

namespace SmartParking.Parking
{
    class Park
    {
        /// <summary>
        /// get busy space count
        /// </summary>
        public static int busySpaceCaunt;
        
       /// <summary>
       /// Space carta from Park
       /// </summary>
        Space[,] space;

        static int[,] spaceMatric = new int[4, 5];

        public Park()
        {
            space = new Space[4, 5];
        }

        static bool Free(int r, int c)
        {
            if (spaceMatric[r, c] == 1)
            {
                return false;
            }

            spaceMatric[r, c] = 1;

            return true;
        }

        /// <summary>
        /// Tabloo of the Park
        /// </summary>
        public static void Tabloo()
        {
            for (int i = 0; i < spaceMatric.GetLength(0); i++)
            {
                for (int j = 0; j < spaceMatric.GetLength(1); j++)
                {
                    if (spaceMatric[i, j] == 0)
                    {
                        Console.Write(" [_] ");
                    }
                    else
                    {
                       
                        Console.Write(" [#] ");
                    }
                }
                Console.WriteLine();
            }
        }

     

        public Space this[int row, int column]
        {
            get
            {
                return space[row, column];
            }
            set
            {
                if (Free(row, column))
                {
                    Console.WriteLine($"This {row} row, {column} column is already busy\n");
                    space[row, column] = value;
                }
                else
                {
                    busySpaceCaunt--;
                    throw new Exception("This space is busy");
                }
            }
        }


        public static bool operator ==(Park park, Park park1)
        {
            return park.space.Length == park1.space.Length;
        }

        public static bool operator !=(Park park, Park park1)
        {
            return park.space.Length != park1.space.Length;
        }

        public static bool operator >(Park park, Park park1)
        {
            return park.space.Length > park1.space.Length;
        }

        public static bool operator <(Park park, Park park1)
        {
            return park.space.Length < park1.space.Length;
        }

        public static bool operator >=(Park park, Park park1)
        {
            return park.space.Length >= park1.space.Length;
        }

        public static bool operator <=(Park park, Park park1)
        {
            return park.space.Length <= park1.space.Length;
        }

        public static int operator +(Park park, Park park1)
        {
            return park.space.Length + park1.space.Length;
        }

        public static int operator -(Park park, Park park1)
        {
            return park.space.Length - park1.space.Length;
        }

        public static int operator *(Park park, Park park1)
        {
            return park.space.Length * park1.space.Length;
        }

        public static int operator /(Park park, Park park1)
        {
            return park.space.Length / park1.space.Length;
        }


        //public static implicit operator int(Park park) 
        //{
        //	return park.space.Length;
        //}
        //public static explicit operator Park(int n) 
        //{
        //	return new Park();
        //}

        public override string ToString()
        {
            return $"\nAll space count  20 place\n" +
                $"Free space count - {20 - busySpaceCaunt} place\n";
        }

        public override bool Equals(object obj)
        {
            return obj is Park park &&
                   space.Length == park.space.Length;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
