using System;

namespace DeutschesCRaute
{
    /// <summary>
    /// Wird ausgelöst, wenn auf einen ungültigen
    /// </summary>
    public class Indexfehler : Ausnahme
    {
        public Indexfehler()
        {
        }

        public Indexfehler(string meldung)
            : base(meldung)
        {
        }

        public Indexfehler(string meldung, Exception innereAusnahme)
            : base(meldung, innereAusnahme)
        {
        }
    }
}
