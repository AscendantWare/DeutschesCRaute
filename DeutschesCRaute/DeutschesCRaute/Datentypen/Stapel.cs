using System;
using System.Collections;
using System.Collections.Generic;

namespace DeutschesCRaute
{
    /// <summary>
    /// Ein Stapel: das zuletzt hinzugefügte Element wird zuerst entfernt (LIFO).
    /// </summary>
    /// <typeparam name="T">Der Typ der Elemente.</typeparam>
    public class Stapel<T> : IEnumerable<T>
    {
        private readonly Stack<T> _elemente = new Stack<T>();

        public int Anzahl
        {
            get { return _elemente.Count; }
        }

        public bool IstLeer
        {
            get { return _elemente.Count == 0; }
        }

        public void Hinlegen(T element)
        {
            _elemente.Push(element);
        }

        public T Nehmen()
        {
            return _elemente.Pop();
        }

        public T Oberstes()
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
