using System.Threading;

namespace DeutschesCRaute
{
    public static class Uhr
    {
        public static void Warte(int millisekunden)
        {
            Thread.Sleep(millisekunden);
        }
    }
}
