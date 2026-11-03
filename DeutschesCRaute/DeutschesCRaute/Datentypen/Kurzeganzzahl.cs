using System;
using System.Globalization;

namespace DeutschesCRaute
{
    /// <summary>
    /// Stellt eine kleine ganze Zahl dar (short).
    /// </summary>
    public readonly struct Kurzeganzzahl : IEquatable<Kurzeganzzahl>,
        IComparable<Kurzeganzzahl>
    {
        public short Wert { get; }

        public Kurzeganzzahl(short wert)
        {
            Wert = wert;
        }

        public static implicit operator Kurzeganzzahl(short wert)
            => new Kurzeganzzahl(wert);

        public static implicit operator short(Kurzeganzzahl zahl)
            => zahl.Wert;

        public static bool operator ==(Kurzeganzzahl a, Kurzeganzzahl b)
            => a.Wert == b.Wert;

        public static bool operator !=(Kurzeganzzahl a, Kurzeganzzahl b)
            => a.Wert != b.Wert;

        public int CompareTo(Kurzeganzzahl andere)
            => Wert.CompareTo(andere.Wert);

        public bool Equals(Kurzeganzzahl andere)
            => Wert == andere.Wert;

        public override bool Equals(object obj)
            => obj is Kurzeganzzahl andere && Equals(andere);

        public override int GetHashCode()
            => Wert.GetHashCode();

        public override string ToString()
            => Wert.ToString(CultureInfo.CurrentCulture);
    }
}
