using System;
using System.Collections.Generic;
using System.Text;

namespace DeutschesCRaute
{
    /// <summary>
    /// Stellt eine Zeichenkette mit deutsch benannten Funktionen dar.
    /// </summary>
    public class Zeichenkette
    {
        private readonly string _inhalt;

        public Zeichenkette(string inhalt)
        {
            _inhalt = inhalt ?? string.Empty;
        }

        public int Laenge
        {
            get { return _inhalt.Length; }
        }

        public bool IstLeer
        {
            get { return _inhalt.Length == 0; }
        }

        public bool IstLeerOderLeerraum
        {
            get { return string.IsNullOrWhiteSpace(_inhalt); }
        }

        public char this[int index]
        {
            get { return _inhalt[index]; }
        }

        public bool Enthaelt(string text)
        {
            return _inhalt.Contains(text);
        }

        public bool BeginntMit(string text)
        {
            return _inhalt.StartsWith(text);
        }

        public bool EndetMit(string text)
        {
            return _inhalt.EndsWith(text);
        }

        public int Suche(string text)
        {
            return _inhalt.IndexOf(text);
        }

        public Zeichenkette Ersetze(string alt, string neu)
        {
            return new Zeichenkette(_inhalt.Replace(alt, neu));
        }

        public Zeichenkette Teil(int startIndex)
        {
            return new Zeichenkette(_inhalt.Substring(startIndex));
        }

        public Zeichenkette Teil(int startIndex, int laenge)
        {
            return new Zeichenkette(_inhalt.Substring(startIndex, laenge));
        }

        public Zeichenkette InGrossbuchstaben()
        {
            return new Zeichenkette(_inhalt.ToUpper());
        }

        public Zeichenkette InKleinbuchstaben()
        {
            return new Zeichenkette(_inhalt.ToLower());
        }

        public Zeichenkette OhneLeerraum()
        {
            return new Zeichenkette(_inhalt.Trim());
        }

        public Zeichenkette AufteilenUndVerbinden(
            string trennzeichen,
            string ersatz)
        {
            return new Zeichenkette(
                string.Join(ersatz, _inhalt.Split(
                    new string[] { trennzeichen },
                    StringSplitOptions.None)));
        }

        public bool Gleich(string andererText)
        {
            return string.Equals(_inhalt, andererText);
        }

        public bool GleichOhneGrossKleinschreibung(string andererText)
        {
            return string.Equals(
                _inhalt,
                andererText,
                StringComparison.OrdinalIgnoreCase);
        }

        public string AlsText()
        {
            return _inhalt;
        }

        public override string ToString()
        {
            return _inhalt;
        }

        public override bool Equals(object obj)
        {
            Zeichenkette andere = obj as Zeichenkette;

            if (andere == null)
                return false;

            return _inhalt == andere._inhalt;
        }

        public override int GetHashCode()
        {
            return _inhalt.GetHashCode();
        }

        public static implicit operator Zeichenkette(string text)
        {
            return new Zeichenkette(text);
        }

        public static implicit operator string(Zeichenkette text)
        {
            return text == null ? null : text._inhalt;
        }

        public static Zeichenkette operator +(
            Zeichenkette links,
            Zeichenkette rechts)
        {
            return new Zeichenkette(
                (links == null ? string.Empty : links._inhalt) +
                (rechts == null ? string.Empty : rechts._inhalt));
        }

        public static bool operator ==(
            Zeichenkette links,
            Zeichenkette rechts)
        {
            if (ReferenceEquals(links, rechts))
                return true;

            if (ReferenceEquals(links, null) ||
                ReferenceEquals(rechts, null))
                return false;

            return links._inhalt == rechts._inhalt;
        }

        public static bool operator !=(
            Zeichenkette links,
            Zeichenkette rechts)
        {
            return !(links == rechts);
        }
    }
}
