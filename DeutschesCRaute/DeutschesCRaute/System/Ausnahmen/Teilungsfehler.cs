using System;

namespace DeutschesCRaute
{
    /// <summary>
    /// Wird ausgelöst, wenn durch null
    /// </summary>
    public class Teilungsfehler : Ausnahme
    {
        public Teilungsfehler()
        {
        }

        public Teilungsfehler(string meldung)
            : base(meldung)
        {
        }

        public Teilungsfehler(string meldung, Exception innereAusnahme)
            : base(meldung, innereAusnahme)
        {
        }
    }
}
