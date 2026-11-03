using System;
using System.Collections;
using System.Collections.Generic;

namespace DeutschesCRaute
{
    /// <summary>
    /// Stellt ein Feld (Array) fester Länge dar.
    /// </summary>
    /// <typeparam name="T">Der Typ der Elemente.</typeparam>
    public class Feld<T> : IEnumerable<T>
    {
        private readonly T[] _elemente;

        /// <summary>
        /// Erstellt ein Feld mit der angegebenen Länge.
        /// </summary>
        public Feld(int laenge)
        {
            _elemente = new T[laenge];
        }

        /// <summary>
        /// Erstellt ein Feld aus vorhandenen Elementen.
        /// </summary>
        public Feld(params T[] elemente)
        {
            _elemente = elemente ?? throw new ArgumentNullException(nameof(elemente));
        }

        /// <summary>
        /// Anzahl der Elemente im Feld.
        /// </summary>
        public int Laenge
        {
            get { return _elemente.Length; }
        }

        /// <summary>
        /// Liest oder setzt ein Element anhand seiner Position.
        /// </summary>
        public T this[int index]
        {
            get { return _elemente[index]; }
            set { _elemente[index] = value; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_elemente).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
