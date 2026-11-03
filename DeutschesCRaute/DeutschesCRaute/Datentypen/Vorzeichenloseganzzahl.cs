using System;
using System.Globalization;

namespace DeutschesCRaute
{
    /// <summary>
    /// Stellt eine ganze Zahl ohne Vorzeichen dar (uint).
    /// </summary>
    public readonly struct Vorzeichenloseganzzahl : IEquatable<Vorzeichenloseganzzahl>,
        IComparable<Vorzeichenloseganzzahl>
    {
        public uint Wert { get; }

        public Vorzeichenloseganzzahl(uint wert)
        {
            Wert = wert;
        }

        public static implicit operator Vorzeichenloseganzzahl(uint wert)
            => new Vorzeichenloseganzzahl(wert);

        public static implicit operator uint(Vorzeichenloseganzzahl zahl)
            => zahl.Wert;

        public static Vorzeichenloseganzzahl operator +(
            Vorzeichenloseganzzahl a,
            Vorzeichenloseganzzahl b)
            => new Vorzeichenloseganzzahl(a.Wert + b.Wert);

        public static Vorzeichenloseganzzahl operator -(
            Vorzeichenloseganzzahl a,
            Vorzeichenloseganzzahl b)
            => new Vorzeichenloseganzzahl(a.Wert - b.Wert);

        public static Vorzeichenloseganzzahl operator *(
            Vorzeichenloseganzzahl a,
            Vorzeichenloseganzzahl b)
            => new Vorzeichenloseganzzahl(a.Wert * b.Wert);

        public static Vorzeichenloseganzzahl operator /(
            Vorzeichenloseganzzahl a,
            Vorzeichenloseganzzahl b)
            => new Vorzeichenloseganzzahl(a.Wert / b.Wert);

        public static bool operator ==(Vorzeichenloseganzzahl a, Vorzeichenloseganzzahl b)
            => a.Wert == b.Wert;

        public static bool operator !=(Vorzeichenloseganzzahl a, Vorzeichenloseganzzahl b)
            => a.Wert != b.Wert;

        public int CompareTo(Vorzeichenloseganzzahl andere)
            => Wert.CompareTo(andere.Wert);

        public bool Equals(Vorzeichenloseganzzahl andere)
            => Wert == andere.Wert;

        public override bool Equals(object obj)
            => obj is Vorzeichenloseganzzahl andere && Equals(andere);

        public override int GetHashCode()
            => Wert.GetHashCode();

        public override string ToString()
            => Wert.ToString(CultureInfo.CurrentCulture);
    }
}
