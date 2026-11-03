using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DeutschesCRaute
{
    /// <summary>
    /// Stellt eine deutsche Dezimalzahl auf Basis von System.Decimal dar.
    /// </summary>
    public readonly struct Dezimalzahl :
        IEquatable<Dezimalzahl>,
        IComparable<Dezimalzahl>,
        IFormattable
    {
        /// <summary>
        /// Der zugrunde liegende Dezimalwert.
        /// </summary>
        public decimal Wert { get; }

        /// <summary>
        /// Erstellt eine neue Dezimalzahl.
        /// </summary>
        public Dezimalzahl(decimal wert)
        {
            Wert = wert;
        }

        #region Konvertierungen

        public static implicit operator Dezimalzahl(decimal wert)
            => new Dezimalzahl(wert);

        public static implicit operator decimal(Dezimalzahl zahl)
            => zahl.Wert;

        public static implicit operator Dezimalzahl(int wert)
            => new Dezimalzahl(wert);

        public static explicit operator Dezimalzahl(double wert)
            => new Dezimalzahl((decimal)wert);

        #endregion

        #region Rechenoperatoren

        public static Dezimalzahl operator +(Dezimalzahl a, Dezimalzahl b)
            => new Dezimalzahl(a.Wert + b.Wert);

        public static Dezimalzahl operator -(Dezimalzahl a, Dezimalzahl b)
            => new Dezimalzahl(a.Wert - b.Wert);

        public static Dezimalzahl operator *(Dezimalzahl a, Dezimalzahl b)
            => new Dezimalzahl(a.Wert * b.Wert);

        public static Dezimalzahl operator /(Dezimalzahl a, Dezimalzahl b)
            => new Dezimalzahl(a.Wert / b.Wert);

        public static Dezimalzahl operator %(Dezimalzahl a, Dezimalzahl b)
            => new Dezimalzahl(a.Wert % b.Wert);

        public static Dezimalzahl operator -(Dezimalzahl zahl)
            => new Dezimalzahl(-zahl.Wert);

        public static Dezimalzahl operator +(Dezimalzahl zahl)
            => zahl;

        #endregion

        #region Vergleichsoperatoren

        public static bool operator ==(Dezimalzahl a, Dezimalzahl b)
            => a.Wert == b.Wert;

        public static bool operator !=(Dezimalzahl a, Dezimalzahl b)
            => a.Wert != b.Wert;

        public static bool operator <(Dezimalzahl a, Dezimalzahl b)
            => a.Wert < b.Wert;

        public static bool operator >(Dezimalzahl a, Dezimalzahl b)
            => a.Wert > b.Wert;

        public static bool operator <=(Dezimalzahl a, Dezimalzahl b)
            => a.Wert <= b.Wert;

        public static bool operator >=(Dezimalzahl a, Dezimalzahl b)
            => a.Wert >= b.Wert;

        #endregion

        #region Vergleich und Gleichheit

        public int CompareTo(Dezimalzahl andere)
            => Wert.CompareTo(andere.Wert);

        public bool Equals(Dezimalzahl andere)
            => Wert == andere.Wert;

        public override bool Equals(object obj)
            => obj is Dezimalzahl andere && Equals(andere);

        public override int GetHashCode()
            => Wert.GetHashCode();

        #endregion

        #region Parsing und Formatierung

        public static Dezimalzahl Parse(
            string text,
            IFormatProvider formatProvider = null)
        {
            return new Dezimalzahl(
                decimal.Parse(
                    text,
                    NumberStyles.Number,
                    formatProvider ?? CultureInfo.CurrentCulture));
        }

        public static bool TryParse(
            string text,
            out Dezimalzahl ergebnis,
            IFormatProvider formatProvider = null)
        {
            bool erfolgreich = decimal.TryParse(
                text,
                NumberStyles.Number,
                formatProvider ?? CultureInfo.CurrentCulture,
                out decimal wert);

            ergebnis = new Dezimalzahl(wert);

            return erfolgreich;
        }

        public override string ToString()
            => Wert.ToString(CultureInfo.CurrentCulture);

        public string ToString(
            string format,
            IFormatProvider formatProvider)
        {
            return Wert.ToString(format, formatProvider);
        }

        #endregion

        #region Hilfsfunktionen

        public Dezimalzahl Runden(int nachkommastellen = 2)
            => new Dezimalzahl(decimal.Round(Wert, nachkommastellen));

        public Dezimalzahl Absolut()
            => new Dezimalzahl(Math.Abs(Wert));

        public Dezimalzahl Minimum(Dezimalzahl andere)
            => new Dezimalzahl(Math.Min(Wert, andere.Wert));

        public Dezimalzahl Maximum(Dezimalzahl andere)
            => new Dezimalzahl(Math.Max(Wert, andere.Wert));

        #endregion
    }
}
