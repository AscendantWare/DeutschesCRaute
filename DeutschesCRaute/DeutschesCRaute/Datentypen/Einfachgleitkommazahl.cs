using System;
using System.Globalization;

namespace DeutschesCRaute
{
    /// <summary>
    /// Stellt eine Gleitkommazahl mit einfacher Genauigkeit dar (float).
    /// </summary>
    public readonly struct Einfachgleitkommazahl : IEquatable<Einfachgleitkommazahl>,
        IComparable<Einfachgleitkommazahl>
    {
        public float Wert { get; }

        public Einfachgleitkommazahl(float wert)
        {
            Wert = wert;
        }

        public static implicit operator Einfachgleitkommazahl(float wert)
            => new Einfachgleitkommazahl(wert);

        public static implicit operator float(Einfachgleitkommazahl zahl)
            => zahl.Wert;

        public static Einfachgleitkommazahl operator +(
            Einfachgleitkommazahl a,
            Einfachgleitkommazahl b)
            => new Einfachgleitkommazahl(a.Wert + b.Wert);

        public static Einfachgleitkommazahl operator -(
            Einfachgleitkommazahl a,
            Einfachgleitkommazahl b)
            => new Einfachgleitkommazahl(a.Wert - b.Wert);

        public static Einfachgleitkommazahl operator *(
            Einfachgleitkommazahl a,
            Einfachgleitkommazahl b)
            => new Einfachgleitkommazahl(a.Wert * b.Wert);

        public static Einfachgleitkommazahl operator /(
            Einfachgleitkommazahl a,
            Einfachgleitkommazahl b)
            => new Einfachgleitkommazahl(a.Wert / b.Wert);

        public static bool operator ==(Einfachgleitkommazahl a, Einfachgleitkommazahl b)
            => a.Wert == b.Wert;

        public static bool operator !=(Einfachgleitkommazahl a, Einfachgleitkommazahl b)
            => a.Wert != b.Wert;

        public static bool operator <(Einfachgleitkommazahl a, Einfachgleitkommazahl b)
            => a.Wert < b.Wert;

        public static bool operator >(Einfachgleitkommazahl a, Einfachgleitkommazahl b)
            => a.Wert > b.Wert;

        public static bool operator <=(Einfachgleitkommazahl a, Einfachgleitkommazahl b)
            => a.Wert <= b.Wert;

        public static bool operator >=(Einfachgleitkommazahl a, Einfachgleitkommazahl b)
            => a.Wert >= b.Wert;

        public int CompareTo(Einfachgleitkommazahl andere)
            => Wert.CompareTo(andere.Wert);

        public bool Equals(Einfachgleitkommazahl andere)
            => Wert.Equals(andere.Wert);

        public override bool Equals(object obj)
            => obj is Einfachgleitkommazahl andere && Equals(andere);

        public override int GetHashCode()
            => Wert.GetHashCode();

        public override string ToString()
            => Wert.ToString(CultureInfo.CurrentCulture);
    }
}
