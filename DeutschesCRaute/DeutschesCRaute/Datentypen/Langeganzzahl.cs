using System;
using System.Globalization;

namespace DeutschesCRaute
{
    /// <summary>
    /// Stellt eine groﬂe ganze Zahl dar (long).
    /// </summary>
    public readonly struct Langeganzzahl : IEquatable<Langeganzzahl>,
        IComparable<Langeganzzahl>
    {
        public long Wert { get; }

        public Langeganzzahl(long wert)
        {
            Wert = wert;
        }

        public static implicit operator Langeganzzahl(long wert)
            => new Langeganzzahl(wert);

        public static implicit operator long(Langeganzzahl zahl)
            => zahl.Wert;

        public static Langeganzzahl operator +(Langeganzzahl a, Langeganzzahl b)
            => new Langeganzzahl(a.Wert + b.Wert);

        public static Langeganzzahl operator -(Langeganzzahl a, Langeganzzahl b)
            => new Langeganzzahl(a.Wert - b.Wert);

        public static Langeganzzahl operator *(Langeganzzahl a, Langeganzzahl b)
            => new Langeganzzahl(a.Wert * b.Wert);

        public static Langeganzzahl operator /(Langeganzzahl a, Langeganzzahl b)
            => new Langeganzzahl(a.Wert / b.Wert);

        public static Langeganzzahl operator %(Langeganzzahl a, Langeganzzahl b)
            => new Langeganzzahl(a.Wert % b.Wert);

        public static bool operator ==(Langeganzzahl a, Langeganzzahl b)
            => a.Wert == b.Wert;

        public static bool operator !=(Langeganzzahl a, Langeganzzahl b)
            => a.Wert != b.Wert;

        public static bool operator <(Langeganzzahl a, Langeganzzahl b)
            => a.Wert < b.Wert;

        public static bool operator >(Langeganzzahl a, Langeganzzahl b)
            => a.Wert > b.Wert;

        public static bool operator <=(Langeganzzahl a, Langeganzzahl b)
            => a.Wert <= b.Wert;

        public static bool operator >=(Langeganzzahl a, Langeganzzahl b)
            => a.Wert >= b.Wert;

        public int CompareTo(Langeganzzahl andere)
            => Wert.CompareTo(andere.Wert);

        public bool Equals(Langeganzzahl andere)
            => Wert == andere.Wert;

        public override bool Equals(object obj)
            => obj is Langeganzzahl andere && Equals(andere);

        public override int GetHashCode()
            => Wert.GetHashCode();

        public override string ToString()
            => Wert.ToString(CultureInfo.CurrentCulture);
    }
}
