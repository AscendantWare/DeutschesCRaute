# DeutschesCRaute

DeutschesCRaute ist eine C#-Bibliothek, die Datentypen, Sammlungen und Hilfsfunktionen mit deutschen Namen bereitstellt. Sie richtet sich an Anfängerinnen und Anfänger, die die Programmierung in ihrer Muttersprache lernen möchten.

## Installation

```
dotnet add package DeutschesCRaute
```

Alternativ über den NuGet-Paketmanager in Visual Studio nach `DeutschesCRaute` suchen.

## Schnellstart

Alle Typen liegen im Namespace `DeutschesCRaute`. Es reicht eine einzige Using-Direktive:

```csharp
using DeutschesCRaute;

Ganzzahl zahl = 5;
Zeichenkette name = "Welt";

Konsole.SchreibeZeile($"Hallo {name}, die Zahl ist {zahl}.");
```

## Enthaltene Typen

### Zahlen

| Typ | Entspricht | Beschreibung |
|---|---|---|
| `Ganzzahl` | `int` | Ganze Zahl mit Rechenoperatoren |
| `Langeganzzahl` | `long` | Große ganze Zahl mit Rechenoperatoren |
| `Kurzeganzzahl` | `short` | Kleine ganze Zahl |
| `Bytezahl` | `byte` | Zahl von 0 bis 255 |
| `Vorzeichenloseganzzahl` | `uint` | Ganze Zahl ohne Vorzeichen mit Rechenoperatoren |
| `Dezimalzahl` | `decimal` | Dezimalzahl mit `Runden`, `Absolut`, `Minimum`, `Maximum` |
| `Gleitkommazahl` | `double` | Gleitkommazahl mit doppelter Genauigkeit |
| `Einfachgleitkommazahl` | `float` | Gleitkommazahl mit einfacher Genauigkeit |

### Text und Wahrheitswerte

| Typ | Beschreibung |
|---|---|
| `Zeichen` | Einzelnes Zeichen mit `IstBuchstabe`, `IstZiffer`, `IstLeerraum` |
| `Zeichenkette` | Text mit Methoden wie `Laenge`, `Enthaelt`, `Ersetze`, `Teil`, `InGrossbuchstaben` |
| `Wahrheitswert` | Logischer Wert mit `Wahr`, `Falsch` und logischen Operatoren |

### Sammlungen

| Typ | Beschreibung |
|---|---|
| `Liste<T>` | Veränderbare Liste mit `Hinzufuegen`, `Entfernen`, `Enthaelt`, `Leeren` |
| `Feld<T>` | Feld fester Länge mit Zugriff über den Index |
| `Menge<T>` | Sammlung eindeutiger Elemente mit `Hinzufuegen`, `EnthaeltAlle`, `SchnittmengeMit` |
| `Wörterbuch<TSchluessel, TWert>` | Schlüssel-Wert-Paare mit `Hinzufuegen`, `EnthaeltSchluessel`, `VersucheWertZuErhalten` |
| `Stapel<T>` | Last-In-First-Out-Sammlung mit `Hinlegen`, `Nehmen`, `Oberstes` |
| `Warteschlange<T>` | First-In-First-Out-Sammlung mit `HintenAnstellen`, `VorneEntnehmen`, `Vorderstes` |

### Zeit

| Typ | Beschreibung |
|---|---|
| `Zeitpunkt` | Kapselt `DateTime` mit Methoden wie `AddiereTage`, `LiegtVor`, `DifferenzZu`, `AlsText` |

### System

| Typ | Beschreibung |
|---|---|
| `Konsole` | Ein- und Ausgabe mit `Schreibe`, `SchreibeZeile`, `LiesZeile` |
| `Datei` | Dateien prüfen, lesen, schreiben und löschen |
| `Verzeichnis` | Verzeichnisse prüfen, erstellen und löschen |
| `Uhr` | Wartet mit `Warte` für eine angegebene Zeit in Millisekunden |
| `Zufallsgenerator` | Erzeugt Zufallszahlen mit `Zahl(minimum, maximum)` |

### Ausnahmen

| Typ | Beschreibung |
|---|---|
| `Ausnahme` | Basisklasse für Ausnahmen der Bibliothek |
| `Teilungsfehler` | Division durch null |
| `Indexfehler` | Ungültiger Index |
| `Nullverweisfehler` | Zugriff auf ein nicht vorhandenes Objekt |

## Beispiel

```csharp
using DeutschesCRaute;

Liste<Zeichenkette> einkaufsliste = new Liste<Zeichenkette>();
einkaufsliste.Hinzufuegen("Brot");
einkaufsliste.Hinzufuegen("Milch");

Konsole.SchreibeZeile($"Anzahl: {einkaufsliste.Anzahl}");

Stapel<Ganzzahl> stapel = new Stapel<Ganzzahl>();
stapel.Hinlegen(1);
stapel.Hinlegen(2);
Konsole.SchreibeZeile($"Oberstes: {stapel.Oberstes()}");
```

## Ziel

Die Bibliothek erleichtert den Einstieg in C#, indem zentrale Begriffe und Funktionen auf Deutsch benannt sind. Die Typen sind implizit in ihre C#-Entsprechungen umwandelbar.

## Kompatibilität

- Zielplattform: .NET Standard 2.0 (verwendbar in .NET Framework 4.6.1+, .NET Core 2.0+, .NET 5+).

## Namenskonventionen

- Typen und Methoden verwenden deutsche Begriffe, z. B. `Zeichenkette`, `Liste`, `Ausnahme`.
- Methoden sind Verben im Infinitiv bzw. Präsens, z. B. `Hinzufuegen`, `Enthaelt`, `Loeschen`.
- Eigenschaften sind Substantive oder Adjektive, z. B. `Anzahl`, `IstLeer`.

## Quellcode

https://github.com/AscendantWare/DeutschesCRaute
