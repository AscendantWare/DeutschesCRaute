using System;
using System.Collections.Generic;
using System.Text;

namespace DeutschesCRaute
{
    public class Liste<T> : List<T>
    {
        public void Hinzufuegen(T element)
        {
            Add(element);
        }

        public void Entfernen(T element)
        {
            Remove(element);
        }

        public bool Enthaelt(T element)
        {
            return Contains(element);
        }

        public void Leeren()
        {
            Clear();
        }

        public int Anzahl
        {
            get => Count;
        }
    }
}
