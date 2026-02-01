# AbilityScoreTester


## Beskrivelse

AbilityScoreTester er et enkelt konsollprogram i C# som beregner en ability score basert på brukerdefinerte parametere. 

Programmet er inspirert av klassiske rollespill-mekanikker (f.eks. D&D) og demonstrerer 
grunnleggende konsepter innen input-håndtering, aritmetikk og objektorientert programmering.

______________________________________________________________________

## Funksjonalitet

Programmet:
-	Leser inn heltall og desimaltall fra bruker
-	Gjenbruker sist brukte verdier som standard
-	Utfører en beregning av ability score basert på:
  -	terningkast (RollResult)
  -	divisjon (DivideBy)
  -	addisjon (AddAmount)
  -	minimumsgrense (Minimum)
-	Lar brukeren kjøre beregningen gjentatte ganger i en løkke
-	Avsluttes eksplisitt ved tastetrykk (Q)

_______________________________________________________________________

## Beregningslogikk

Ability score beregnes slik:
1.	RollResult divideres med DivideBy
2.	Resultatet trunkeres til heltall
3.	AddAmount legges til
4.	Hvis resultatet er lavere enn Minimum, brukes Minimum

### Formelt:
Score = max( Minimum, AddAmount + (int)(RollResult / DivideBy) )

_______________________________________________________________________

## Struktur

Programmet består av to klasser:

- ###	Program
  -	Inneholder Main
  -	Håndterer brukerinput og kontrollflyt
  -	Inneholder hjelpefunksjoner for trygg parsing (ReadInt, ReadDouble)

-	### AbilityScoreCalculator
  -	Inneholder felt for beregningsparametere
  -	Utfører selve beregningen i CalculateAbilityScore()

_______________________________________________________________________

## Teknologi

-	Språk: C#
-	Plattform: .NET (konsollapplikasjon)
-	Eksterne biblioteker: Ingen

______________________________________________________________________

## Læringsmål

Programmet demonstrerer:
-	Objektorientert design
-	Input-validering med TryParse
-	Kontrollstrukturer (while, if/else)
-	Enkel numerisk behandling og typekonvertering
-	God praksis rundt gjenbruk av kode og lesbarhet

______________________________________________________________________

## Kjøring

Kompiler og kjør programmet som en vanlig C#-konsollapplikasjon. 

Følg instruksjonene i terminalen for å angi verdier eller bruke standardverdier.

______________________________________________________________________

## Status

Prosjektet er ferdig og fungerer som tiltenkt.
