using System.IO;

namespace DeutschesCRaute
{
    public static class Verzeichnis
    {
        public static bool Existiert(string pfad)
        {
            return Directory.Exists(pfad);
        }

        public static void Erstellen(string pfad)
        {
            Directory.CreateDirectory(pfad);
        }

        public static void Loeschen(string pfad)
        {
            Directory.Delete(pfad, true);
        }
    }
}
