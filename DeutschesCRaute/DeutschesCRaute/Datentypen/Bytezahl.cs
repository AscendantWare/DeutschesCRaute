using System;
using System.Globalization;

namespace DeutschesCRaute
{
    /// <summary>
    /// Stellt eine Zahl von 0 bis 255 dar (byte).
    /// </summary>
    public readonly struct Bytezahl : IEquatable<Bytezahl>,
        IComparable<Bytezahl>
    {
        public byte Wert { get; }

        public Bytezahl(byte wert)
        {
            Wert = wert;
        }

        public static implicit operator Bytezahl(byte wert)
            => new Bytezahl(wert);

        public static implicit operator byte(Bytezahl zahl)
            => zahl.Wert;

        public static bool operator ==(Bytezahl a, Bytezahl b)
            => a.Wert == b.Wert;

        public static bool operator !=(Bytezahl a, Bytezahl b)
            => a.Wert != b.Wert;

        public int CompareTo(Bytezahl andere)
            => Wert.CompareTo(andere.Wert);

        public bool Equals(Bytezahl andere)
            => Wert == andere.Wert;

        public override bool Equals(object obj)
            => obj is Bytezahl andere && Equals(andere);

        public override int GetHashCode()
            => Wert.GetHashCode();

        public override string ToString()
            => Wert.ToString(CultureInfo.CurrentCulture);
    }
}
