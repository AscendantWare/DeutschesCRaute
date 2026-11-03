using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DeutschesCRaute
{
    /// <summary>
    /// Stellt eine Menge eindeutiger Elemente dar.
    /// Jedes Element kann nur einmal enthalten sein.
    /// </summary>
    /// <typeparam name="T">Der Typ der Elemente.</typeparam>
    public class Menge<T> : IEnumerable<T>
    {
        private readonly HashSet<T> _elemente;

        /// <summary>
        /// Erstellt eine leere Menge.
        /// </summary>
        public Menge()
        {
            _elemente = new HashSet<T>();
        }

        /// <summary>
        /// Erstellt eine Menge aus einer vorhandenen Sammlung.
        /// Doppelte Elemente werden automatisch entfernt.
        /// </summary>
        public Menge(IEnumerable<T> elemente)
        {
            if (elemente == null)
                throw new ArgumentNullException(nameof(elemente));

            _elemente = new HashSet<T>(elemente);
        }

        /// <summary>
        /// Anzahl der Elemente in der Menge.
        /// </summary>
        public int Anzahl
        {
            get { return _elemente.Count; }
        }

        /// <summary>
        /// Gibt an, ob die Menge leer ist.
        /// </summary>
        public bool IstLeer
        {
            get { return _elemente.Count == 0; }
        }

        /// <summary>
        /// Fügt ein Element hinzu.
        /// Gibt false zurück, wenn es bereits enthalten ist.
        /// </summary>
        public bool Hinzufuegen(T element)
        {
            return _elemente.Add(element);
        }

        /// <summary>
        /// Entfernt ein Element.
        /// Gibt false zurück, wenn es nicht enthalten war.
        /// </summary>
        public bool Entfernen(T element)
        {
            return _elemente.Remove(element);
        }

        /// <summary>
        /// Entfernt alle Elemente.
        /// </summary>
        public void Leeren()
        {
            _elemente.Clear();
        }

        /// <summary>
        /// Prüft, ob ein Element enthalten ist.
        /// </summary>
        public bool Enthaelt(T element)
        {
            return _elemente.Contains(element);
        }

        /// <summary>
        /// Fügt alle Elemente einer anderen Sammlung hinzu.
        /// </summary>
        public void AlleHinzufuegen(IEnumerable<T> elemente)
        {
            if (elemente == null)
                throw new ArgumentNullException(nameof(elemente));

            _elemente.UnionWith(elemente);
        }

        /// <summary>
        /// Behält nur Elemente, die auch in der angegebenen Sammlung vorkommen.
        /// </summary>
        public void SchnittmengeMit(IEnumerable<T> elemente)
        {
            if (elemente == null)
                throw new ArgumentNullException(nameof(elemente));

            _elemente.IntersectWith(elemente);
        }

        /// <summary>
        /// Entfernt alle Elemente, die auch in der angegebenen Sammlung vorkommen.
        /// </summary>
        public void DifferenzMit(IEnumerable<T> elemente)
        {
            if (elemente == null)
                throw new ArgumentNullException(nameof(elemente));

            _elemente.ExceptWith(elemente);
        }

        /// <summary>
        /// Prüft, ob alle Elemente der angegebenen Sammlung enthalten sind.
        /// </summary>
        public bool EnthaeltAlle(IEnumerable<T> elemente)
        {
            if (elemente == null)
                throw new ArgumentNullException(nameof(elemente));

            return _elemente.IsSupersetOf(elemente);
        }

        /// <summary>
        /// Prüft, ob mindestens ein Element enthalten ist.
        /// </summary>
        public bool EnthaeltEines(IEnumerable<T> elemente)
        {
            if (elemente == null)
                throw new ArgumentNullException(nameof(elemente));

            return _elemente.Overlaps(elemente);
        }

        /// <summary>
        /// Prüft, ob alle Elemente der Menge in der angegebenen Sammlung enthalten sind.
        /// </summary>
        public bool IstTeilmengeVon(IEnumerable<T> elemente)
        {
            if (elemente == null)
                throw new ArgumentNullException(nameof(elemente));

            return _elemente.IsSubsetOf(elemente);
        }

        /// <summary>
        /// Gibt die Elemente als Array zurück.
        /// </summary>
        public T[] AlsFeld()
        {
            T[] ergebnis = new T[_elemente.Count];
            _elemente.CopyTo(ergebnis);
            return ergebnis;
        }

        /// <summary>
        /// Ermöglicht die Iteration über die Elemente.
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            return _elemente.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
