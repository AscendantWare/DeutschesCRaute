using System;

namespace DeutschesCRaute
{
    public static class Zufallsgenerator
    {
        private static readonly Random _zufall = new Random();

        public static int Zahl(int minimum, int maximum)
        {
            return _zufall.Next(minimum, maximum);
        }
    }
}
