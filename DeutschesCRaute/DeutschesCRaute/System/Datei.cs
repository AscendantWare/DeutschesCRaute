using System.IO;

namespace DeutschesCRaute
{
    public static class Datei
    {
        public static bool Existiert(string pfad)
        {
            return File.Exists(pfad);
        }

        public static string LiesAlleText(string pfad)
        {
            return File.ReadAllText(pfad);
        }

        public static void SchreibeAlleText(string pfad, string text)
        {
            File.WriteAllText(pfad, text);
        }

        public static void Loeschen(string pfad)
        {
            File.Delete(pfad);
        }
    }
}
