#Pflichtenheft, Kurzfassung
###Team
Die Gruppe 7 aus der Klasse FA26 besteht aus
* Nicolas Tietz
* Katrin Wistuba
* Tom Zimmerlinkat

##Problemstellung
Mit Hilfe dieser Software soll ein Postfachverwaltung für eine firmeninterne Poststelle ermöglicht werden. Sendungen und Pakete werden angenommen, in designierten Postfächern zwischengelagert und später wieder an den Empfänger ausgegeben.
Der Funktionsumfang wird bewusst schlicht gehalten. Besondere Sicherheitsfunktionen wie z.B. Nutzerverwaltung und Authentifizierung werden nicht implementiert da das Nutzungsszenario in einer vertrauten Umgebung stattfindet.
##Datenhaltung
Die Primäre Datenhaltung soll in einer relationalen SQL Datenbank erfolgen (MySQL o.ä.).
Darüber hinaus soll eine zweite Lösung mit einer In-memory-Datenbank präsentiert werden, diese hat ein XML Speicher zwischen Sitzungen als Sicherung.
##ER-Modell
[Paket](Absender)(Empfänger)(Abmaße)--1:1--<einlagern(Datum)>--[Postfach]--<ausgeben(Datum)>-- [Empfänger]
##User interfaces
Es sollen zwei verschiedenartige Nutzerschnittstellen zur verfügung gestellt werden.
###GUI
Eine graphische Oberfläche die "nativ" von der Applikation ausgegeben wird für eine fensterbasierte Arbeitsumgebung. Diese bietet möglichkeiten alle wichtigen Funktionen auszulösen. Darüber hinaus ist es komfortabel möglich den Datenbestand einzusehen.
###CLI
Auch ein Text-basiertes Komandozeilen Interface soll ebenfalls aufgerufen werden können. Auch hier sollten alle Hauptfunktionen nutzbar sein. Die Bedienung erfolgt über ein  Knopf-zu-Funktion System. Eine interaktive shell ist nicht vorgesehen.
##Testszenarien
##Meilensteine
