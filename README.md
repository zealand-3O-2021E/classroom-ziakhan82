# ClassRoom opgave

**Formål: at genopfriske begreberne class, properties, constructor, private/public, if/switch, git**


Via linket fra Github. Clone “projeket” fra GitHub til din egen maskine


Projektet indeholder kun templaten til en console applikation. Din opgave er at fylde den med kode.

## Opgave 1: 

Tilføj en klasse (public) “Studerende”, den skal indeholde tre properties. Disse tre properties skal være synlige uden for klassen men må kun sættes indenfor denne klasse.

* string Navn
* int fødselsmåned
* int fødselsdag

Du skal også have en constructor som tager tre parametre så du kan få sat dine properties.
Husk at comitte og pushe til Git repo(GitHub). :octocat:


## Opgave 2:
Tilføj en ny klasse “KlasseRum”, med følgende properties.

* string KlasseNavn
* List\<Studerende> Klasseliste
* DateTime SemesterStart

Opret en default constructor.


Husk at comitte og pushe til Git repo (GitHub). :octocat:


## Opgave 3:

Vi skal nu tilføje data. Det gør vi i Main metoden.

Opret en instans af KlasseRum 

KlasseNavn: 3B

SemesterStart: 4-9-2018 

Tilføj dig selv og dem du sidder ved siden af i listen over studerende


Husk at comitte og pushe til Git repo (GitHub). :octocat:


## Opgave 4:
Udskriv de oplysninger som er på dit klasserums object via Console.Writeline()



## Opgave 5:
Der skal nu implementeres en metode ”årstid ”  som returner en string og som fortæller på hvilken årstiden den studerende har fødselsdag.
Overvej hvor denne metode skal være.

fødselsmåned | Output årstid
-------------|--------------
12,1,2       | Vinter
3,4,5        | Forår
6,7,8        | Sommer
9,10,11      | Efterår
 

## Opgave 6:
Der skal nu implementeres en metode som tæller op for klassen hvor mange der har fødselsdag i hver årstid. Denne metode returnerer ikke noget, men skal bare skrive resultatet ud i konsollen 
Hvor skal denne metode ligge ?

hint. se om du kan kode det via et linq statement

Kald metoden.

Husk at comitte og pushe til Git repo (GitHub). :octocat:


## Ekstra: Opgave 7
Prøv at sikre at der ikke kan indtastes en fødselsmåned som ligger udenfor intervallet 1-12


