using System;

namespace DeutschesCRaute
{
    /// <summary>
    /// Ein- und Ausgabe
    /// </summary>
    public static class Konsole
    {
        public static void Schreibe(object wert)
        {
            Console.Write(wert);
        }

        public static void SchreibeZeile(object wert = null)
        {
            Console.WriteLine(wert);
        }

        public static string LiesZeile()
        {
            return Console.ReadLine();
        }
    }
}
