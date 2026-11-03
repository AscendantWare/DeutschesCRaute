using System;

namespace DeutschesCRaute
{
    /// <summary>
    /// Wird ausgelöst, wenn auf ein nicht
    /// </summary>
    public class Nullverweisfehler : Ausnahme
    {
        public Nullverweisfehler()
        {
        }

        public Nullverweisfehler(string meldung)
            : base(meldung)
        {
        }

        public Nullverweisfehler(string meldung, Exception innereAusnahme)
            : base(meldung, innereAusnahme)
        {
        }
    }
}
