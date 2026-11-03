using System;

namespace DeutschesCRaute
{
    /// <summary>
    /// Stellt ein einzelnes Zeichen dar (char).
    /// </summary>
    public readonly struct Zeichen : IEquatable<Zeichen>, IComparable<Zeichen>
    {
        public char Wert { get; }

        public Zeichen(char wert)
        {
            Wert = wert;
        }

        public bool IstBuchstabe => char.IsLetter(Wert);

        public bool IstZiffer => char.IsDigit(Wert);

        public bool IstLeerraum => char.IsWhiteSpace(Wert);

        public Zeichen InGrossbuchstaben()
            => new Zeichen(char.ToUpperInvariant(Wert));

        public Zeichen InKleinbuchstaben()
            => new Zeichen(char.ToLowerInvariant(Wert));

        public static implicit operator Zeichen(char wert)
            => new Zeichen(wert);

        public static implicit operator char(Zeichen zeichen)
            => zeichen.Wert;

        public static bool operator ==(Zeichen a, Zeichen b)
            => a.Wert == b.Wert;

        public static bool operator !=(Zeichen a, Zeichen b)
            => a.Wert != b.Wert;

        public int CompareTo(Zeichen andere)
            => Wert.CompareTo(andere.Wert);

        public bool Equals(Zeichen andere)
            => Wert == andere.Wert;

        public override bool Equals(object obj)
            => obj is Zeichen andere && Equals(andere);

        public override int GetHashCode()
            => Wert.GetHashCode();

        public override string ToString()
            => Wert.ToString();
    }
}
