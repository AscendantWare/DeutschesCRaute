using System;
using System.Collections.Generic;
using System.Text;

namespace DeutschesCRaute
{
    /// <summary>
    /// Stellt einen deutschen Wahrheitswert dar.
    /// </summary>
    public struct Wahrheitswert : IEquatable<Wahrheitswert>
    {
        /// <summary>
        /// Der zugrunde liegende Wahrheitswert.
        /// </summary>
        public bool Wert { get; private set; }

        /// <summary>
        /// Erstellt einen neuen Wahrheitswert.
        /// </summary>
        public Wahrheitswert(bool wert)
        {
            Wert = wert;
        }

        #region Statische Werte

        public static Wahrheitswert Wahr
        {
            get { return new Wahrheitswert(true); }
        }

        public static Wahrheitswert Falsch
        {
            get { return new Wahrheitswert(false); }
        }

        #endregion

        #region Konvertierungen

        public static implicit operator Wahrheitswert(bool wert)
        {
            return new Wahrheitswert(wert);
        }

        public static implicit operator bool(Wahrheitswert wert)
        {
            return wert.Wert;
        }

        #endregion

        #region Logische Operatoren

        public static Wahrheitswert operator !(Wahrheitswert wert)
        {
            return new Wahrheitswert(!wert.Wert);
        }

        public static Wahrheitswert operator &(Wahrheitswert a, Wahrheitswert b)
        {
            return new Wahrheitswert(a.Wert & b.Wert);
        }

        public static Wahrheitswert operator |(Wahrheitswert a, Wahrheitswert b)
        {
            return new Wahrheitswert(a.Wert | b.Wert);
        }

        public static Wahrheitswert operator ^(Wahrheitswert a, Wahrheitswert b)
        {
            return new Wahrheitswert(a.Wert ^ b.Wert);
        }

        #endregion

        #region Vergleichsoperatoren

        public static bool operator ==(Wahrheitswert a, Wahrheitswert b)
        {
            return a.Wert == b.Wert;
        }

        public static bool operator !=(Wahrheitswert a, Wahrheitswert b)
        {
            return a.Wert != b.Wert;
        }

        #endregion

        #region Gleichheit

        public bool Equals(Wahrheitswert anderer)
        {
            return Wert == anderer.Wert;
        }

        public override bool Equals(object obj)
        {
            return obj is Wahrheitswert && Equals((Wahrheitswert)obj);
        }

        public override int GetHashCode()
        {
            return Wert.GetHashCode();
        }

        #endregion

        #region Textdarstellung

        public override string ToString()
        {
            return Wert ? "Wahr" : "Falsch";
        }

        #endregion
    }
}
