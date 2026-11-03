using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DeutschesCRaute
{
    /// <summary>
    /// Stellt einen Zeitpunkt dar.
    /// </summary>
    public struct Zeitpunkt : IComparable<Zeitpunkt>, IEquatable<Zeitpunkt>
    {
        private readonly DateTime _zeit;

        public Zeitpunkt(DateTime zeit)
        {
            _zeit = zeit;
        }

        public Zeitpunkt(
            int jahr,
            int monat,
            int tag,
            int stunde,
            int minute,
            int sekunde)
        {
            _zeit = new DateTime(
                jahr, monat, tag, stunde, minute, sekunde);
        }

        public int Jahr { get { return _zeit.Year; } }
        public int Monat { get { return _zeit.Month; } }
        public int Tag { get { return _zeit.Day; } }
        public int Stunde { get { return _zeit.Hour; } }
        public int Minute { get { return _zeit.Minute; } }
        public int Sekunde { get { return _zeit.Second; } }
        public int Millisekunde { get { return _zeit.Millisecond; } }

        public DayOfWeek Wochentag { get { return _zeit.DayOfWeek; } }

        public DateTimeKind Zeitart { get { return _zeit.Kind; } }

        public static Zeitpunkt Jetzt
        {
            get { return new Zeitpunkt(DateTime.Now); }
        }

        public static Zeitpunkt JetztWeltweit
        {
            get { return new Zeitpunkt(DateTime.UtcNow); }
        }

        public static Zeitpunkt Heute
        {
            get { return new Zeitpunkt(DateTime.Today); }
        }

        public Zeitpunkt AddiereTage(double tage)
        {
            return new Zeitpunkt(_zeit.AddDays(tage));
        }

        public Zeitpunkt AddiereStunden(double stunden)
        {
            return new Zeitpunkt(_zeit.AddHours(stunden));
        }

        public Zeitpunkt AddiereMinuten(double minuten)
        {
            return new Zeitpunkt(_zeit.AddMinutes(minuten));
        }

        public Zeitpunkt AddiereSekunden(double sekunden)
        {
            return new Zeitpunkt(_zeit.AddSeconds(sekunden));
        }

        public Zeitpunkt AddiereMonate(int monate)
        {
            return new Zeitpunkt(_zeit.AddMonths(monate));
        }

        public Zeitpunkt AddiereJahre(int jahre)
        {
            return new Zeitpunkt(_zeit.AddYears(jahre));
        }

        public Zeitpunkt AnfangDesTages()
        {
            return new Zeitpunkt(_zeit.Date);
        }

        public Zeitpunkt AlsWeltzeit()
        {
            return new Zeitpunkt(_zeit.ToUniversalTime());
        }

        public Zeitpunkt AlsOrtszeit()
        {
            return new Zeitpunkt(_zeit.ToLocalTime());
        }

        public TimeSpan DifferenzZu(Zeitpunkt anderer)
        {
            return _zeit - anderer._zeit;
        }

        public bool LiegtVor(Zeitpunkt anderer)
        {
            return _zeit < anderer._zeit;
        }

        public bool LiegtNach(Zeitpunkt anderer)
        {
            return _zeit > anderer._zeit;
        }

        public bool IstGleich(Zeitpunkt anderer)
        {
            return _zeit == anderer._zeit;
        }

        public string AlsText()
        {
            return _zeit.ToString("dd.MM.yyyy HH:mm:ss");
        }

        public string AlsText(string format)
        {
            return _zeit.ToString(format, CultureInfo.CurrentCulture);
        }

        public DateTime AlsDateTime()
        {
            return _zeit;
        }

        public int CompareTo(Zeitpunkt anderer)
        {
            return _zeit.CompareTo(anderer._zeit);
        }

        public bool Equals(Zeitpunkt anderer)
        {
            return _zeit.Equals(anderer._zeit);
        }

        public override bool Equals(object obj)
        {
            return obj is Zeitpunkt && Equals((Zeitpunkt)obj);
        }

        public override int GetHashCode()
        {
            return _zeit.GetHashCode();
        }

        public override string ToString()
        {
            return AlsText();
        }

        public static implicit operator Zeitpunkt(DateTime zeit)
        {
            return new Zeitpunkt(zeit);
        }

        public static implicit operator DateTime(Zeitpunkt zeit)
        {
            return zeit._zeit;
        }

        public static bool operator <(Zeitpunkt links, Zeitpunkt rechts)
        {
            return links._zeit < rechts._zeit;
        }

        public static bool operator >(Zeitpunkt links, Zeitpunkt rechts)
        {
            return links._zeit > rechts._zeit;
        }

        public static bool operator <=(Zeitpunkt links, Zeitpunkt rechts)
        {
            return links._zeit <= rechts._zeit;
        }

        public static bool operator >=(Zeitpunkt links, Zeitpunkt rechts)
        {
            return links._zeit >= rechts._zeit;
        }

        public static bool operator ==(Zeitpunkt links, Zeitpunkt rechts)
        {
            return links.Equals(rechts);
        }

        public static bool operator !=(Zeitpunkt links, Zeitpunkt rechts)
        {
            return !links.Equals(rechts);
        }

        public static Zeitpunkt operator +(Zeitpunkt zeit, TimeSpan dauer)
        {
            return new Zeitpunkt(zeit._zeit + dauer);
        }

        public static Zeitpunkt operator -(Zeitpunkt zeit, TimeSpan dauer)
        {
            return new Zeitpunkt(zeit._zeit - dauer);
        }

        public static TimeSpan operator -(Zeitpunkt links, Zeitpunkt rechts)
        {
            return links._zeit - rechts._zeit;
        }
    }
}
