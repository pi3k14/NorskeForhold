# Komme i gang

Det følgende er en enkel beskrivelse av de mest brukte funksjonene i NorskeForhold. Se [API-dokumentasjonen](/api/Kodefabrikken.NorskeForhold.html) for mer informasjon.


## Fødselsnummer
Valider fødselsnummer og inspiser de enkelte deler, f.eks. biologisk kjønn.
``` C#
var fødselsnummer = new Fødselsnummer("23057796111");
// kaster exception hvis noe er galt.
var dato = fødselsnummer.Dato;
var kjønn = fødselsnummer.Kjønn
```

## Organisasjonsnummer
Valider organisasjonsnummer.
``` C#
var organisasjonsnummer = new Organisasjonsnummer("256991144");
// kaster exception hvis noe er galt.
organisasjonsnummer.Value // returns a validated string
```
Ledende og avsluttende mellomrom, samt teksten 'MVA' fjernes.

## Fylker
Alle landets fylker, med kode og offentlige skrivemåter, samt kommunene i fylket.
``` C#
Fylke.AlleFylker;
Fylke.Finnmark.ToString() == "56 Finnmark - Finnmárku - Finmarkku"
```

## Kommuner
Alle landets kommuner, med kode og offentlige skrivemåter samt fylket de ligger i.
``` C#
Kommune.AlleKommuner;
Kommune.Trondheim.Fylke == NorskeForhold.Fylke.Trøndelag;
Kommune.Trondheim.Navn == "Trondheim";
Kommune.Trondheim.Nummer == 5001;
```