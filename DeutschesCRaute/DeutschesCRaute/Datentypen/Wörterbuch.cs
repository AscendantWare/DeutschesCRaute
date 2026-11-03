using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DeutschesCRaute
{
    /// <summary>
    /// Ein Wörterbuch speichert Schlüssel-Wert-Paare.
    /// </summary>
    /// <typeparam name="TSchluessel">Der Typ der Schlüssel.</typeparam>
    /// <typeparam name="TWert">Der Typ der Werte.</typeparam>
    public class Wörterbuch<TSchluessel, TWert>
        : IEnumerable<KeyValuePair<TSchluessel, TWert>>
    {
        private readonly Dictionary<TSchluessel, TWert> _eintraege;

        public Wörterbuch()
        {
            _eintraege = new Dictionary<TSchluessel, TWert>();
        }

        public Wörterbuch(IEqualityComparer<TSchluessel> vergleich)
        {
            _eintraege = new Dictionary<TSchluessel, TWert>(vergleich);
        }

        public int Anzahl
        {
            get { return _eintraege.Count; }
        }

        public bool IstLeer
        {
            get { return _eintraege.Count == 0; }
        }

        /// <summary>
        /// Liest oder setzt einen Wert anhand seines Schlüssels.
        /// </summary>
        public TWert this[TSchluessel schluessel]
        {
            get { return _eintraege[schluessel]; }
            set { _eintraege[schluessel] = value; }
        }

        public ICollection<TSchluessel> Schluessel
        {
            get { return _eintraege.Keys; }
        }

        public ICollection<TWert> Werte
        {
            get { return _eintraege.Values; }
        }

        public void Hinzufuegen(TSchluessel schluessel, TWert wert)
        {
            _eintraege.Add(schluessel, wert);
        }

        public bool VersucheHinzuzufuegen(TSchluessel schluessel, TWert wert)
        {
            if (_eintraege.ContainsKey(schluessel))
                return false;

            _eintraege.Add(schluessel, wert);
            return true;
        }

        public bool Entfernen(TSchluessel schluessel)
        {
            return _eintraege.Remove(schluessel);
        }

        public bool EnthaeltSchluessel(TSchluessel schluessel)
        {
            return _eintraege.ContainsKey(schluessel);
        }

        public bool EnthaeltWert(TWert wert)
        {
            return _eintraege.ContainsValue(wert);
        }

        public bool VersucheWertZuErhalten(
            TSchluessel schluessel,
            out TWert wert)
        {
            return _eintraege.TryGetValue(schluessel, out wert);
        }

        public void HinzufuegenOderErsetzen(
            TSchluessel schluessel,
            TWert wert)
        {
            _eintraege[schluessel] = wert;
        }

        public void Leeren()
        {
            _eintraege.Clear();
        }

        public IEnumerator<KeyValuePair<TSchluessel, TWert>> GetEnumerator()
        {
            return _eintraege.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
