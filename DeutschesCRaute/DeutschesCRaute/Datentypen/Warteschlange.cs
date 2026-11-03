using System;
using System.Collections;
using System.Collections.Generic;

namespace DeutschesCRaute
{
    /// <summary>
    /// Eine Warteschlange: das zuerst hinzugefügte Element wird zuerst entfernt (FIFO).
    /// </summary>
    /// <typeparam name="T">Der Typ der Elemente.</typeparam>
    public class Warteschlange<T> : IEnumerable<T>
    {
        private readonly Queue<T> _elemente = new Queue<T>();

        public int Anzahl
        {
            get { return _elemente.Count; }
        }

        public bool IstLeer
        {
            get { return _elemente.Count == 0; }
        }

        public void HintenAnstellen(T element)
        {
            _elemente.Enqueue(element);
        }

        public T VorneEntnehmen()
        {
            return _elemente.Dequeue();
        }

        public T Vorderstes()
        {
            return _elemente.Peek();
        }

        public void Leeren()
        {
            _elemente.Clear();
        }

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
