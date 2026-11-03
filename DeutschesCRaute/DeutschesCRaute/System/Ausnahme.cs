using System;

namespace DeutschesCRaute
{
    public class Ausnahme : Exception
    {
        public Ausnahme()
        {
        }

        public Ausnahme(string meldung)
            : base(meldung)
        {
        }

        public Ausnahme(string meldung, Exception innereAusnahme)
            : base(meldung, innereAusnahme)
        {
        }
    }
}
