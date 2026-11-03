using System;
using System.Globalization;

namespace DeutschesCRaute
{
    /// <summary>
    /// Stellt eine Gleitkommazahl mit doppelter Genauigkeit dar (double).
    /// </summary>
    public readonly struct Gleitkommazahl : IEquatable<Gleitkommazahl>,
        IComparable<Gleitkommazahl>
    {
        public double Wert { get; }

        public Gleitkommazahl(double wert)
        {
            Wert = wert;
        }

        public static implicit operator Gleitkommazahl(double wert)
            => new Gleitkommazahl(wert);

        public static implicit operator double(Gleitkommazahl zahl)
            => zahl.Wert;

        public static Gleitkommazahl operator +(Gleitkommazahl a, Gleitkommazahl b)
            => new Gleitkommazahl(a.Wert + b.Wert);

        public static Gleitkommazahl operator -(Gleitkommazahl a, Gleitkommazahl b)
            => new Gleitkommazahl(a.Wert - b.Wert);

        public static Gleitkommazahl operator *(Gleitkommazahl a, Gleitkommazahl b)
            => new Gleitkommazahl(a.Wert * b.Wert);

        public static Gleitkommazahl operator /(Gleitkommazahl a, Gleitkommazahl b)
            => new Gleitkommazahl(a.Wert / b.Wert);

        public static bool operator ==(Gleitkommazahl a, Gleitkommazahl b)
            => a.Wert == b.Wert;

        public static bool operator !=(Gleitkommazahl a, Gleitkommazahl b)
            => a.Wert != b.Wert;

        public static bool operator <(Gleitkommazahl a, Gleitkommazahl b)
            => a.Wert < b.Wert;

        public static bool operator >(Gleitkommazahl a, Gleitkommazahl b)
            => a.Wert > b.Wert;

        public static bool operator <=(Gleitkommazahl a, Gleitkommazahl b)
            => a.Wert <= b.Wert;

        public static bool operator >=(Gleitkommazahl a, Gleitkommazahl b)
            => a.Wert >= b.Wert;

        public int CompareTo(Gleitkommazahl andere)
            => Wert.CompareTo(andere.Wert);

        public bool Equals(Gleitkommazahl andere)
            => Wert.Equals(andere.Wert);

        public override bool Equals(object obj)
            => obj is Gleitkommazahl andere && Equals(andere);

        public override int GetHashCode()
            => Wert.GetHashCode();

        public override string ToString()
            => Wert.ToString(CultureInfo.CurrentCulture);
    }
}
