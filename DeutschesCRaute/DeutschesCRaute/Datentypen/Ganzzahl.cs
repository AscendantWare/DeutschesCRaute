using System;
using System.Collections.Generic;
using System.Text;

namespace DeutschesCRaute
{
    public readonly struct Ganzzahl : IEquatable<Ganzzahl>,
        IComparable<Ganzzahl>
    {
        public int Wert { get; }

        public Ganzzahl(int wert)
        {
            Wert = wert;
        }

        public static implicit operator Ganzzahl(int wert)
            => new Ganzzahl(wert);

        public static implicit operator int(Ganzzahl zahl)
            => zahl.Wert;

        public static Ganzzahl operator +(Ganzzahl a, Ganzzahl b)
            => new Ganzzahl(a.Wert + b.Wert);

        public static Ganzzahl operator -(Ganzzahl a, Ganzzahl b)
            => new Ganzzahl(a.Wert - b.Wert);

        public static Ganzzahl operator *(Ganzzahl a, Ganzzahl b)
            => new Ganzzahl(a.Wert * b.Wert);

        public static Ganzzahl operator /(Ganzzahl a, Ganzzahl b)
            => new Ganzzahl(a.Wert / b.Wert);

        public static bool operator ==(Ganzzahl a, Ganzzahl b)
            => a.Wert == b.Wert;

        public static bool operator !=(Ganzzahl a, Ganzzahl b)
            => a.Wert != b.Wert;

        public int CompareTo(Ganzzahl other)
            => Wert.CompareTo(other.Wert);

        public bool Equals(Ganzzahl other)
            => Wert == other.Wert;

        public override bool Equals(object obj)
            => obj is Ganzzahl other && Equals(other);

        public override int GetHashCode()
            => Wert.GetHashCode();

        public override string ToString()
            => Wert.ToString();
    }
}
