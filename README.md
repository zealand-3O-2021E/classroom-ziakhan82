
# ClassRoom assignment (findes på dansk længere nede)

**Purpose: to refresh the concepts of class, properties, constructor, private/public, if/switch, git**

Via the link from Github. Clone the "project" from GitHub to your own machine

The project contains only the template to a console application. Your task is to fill it out with code.

 
## Task 1: 
Add a class (public) "Student", it must contain three properties. These three properties must be visible outside of class but can only be set within this class.

* string name
* int birth month
* int birthday

You also must have a constructor that takes three parameters so you can put your properties.

Remember to commit and push to the Git repo (GitHub). :octocat:

## Task 2:
Add a new class of "ClassRoom", with the following properties. 

* string Class Name
* List \ <Student> Class list
* Datetime Semester Start

Create a default constructor.

Remember to commit and push to the Git repo (GitHub). :octocat:

 

## Task 3:
We must now add some data. We do this in the Main method.

Create an new instance of the ClassRoom class 

Fx:
Class Name: 3Q
Beginning of the semester: 26-8-2019 

Add yourself and those you sit next to in the list of students

Remember to commit and push to the Git repo (GitHub). :octocat:


## Task 4:
Print out the information that is on your classroom object via console.WriteLine ()
 

## Task 5:
There must now be implemented a method "season" the returntype is a string. The methods returns what season for the student's birthday.

Consider how this method should be.

 
birth month  | Output time of the year
-------------|--------------
12, 1, 2     | Winter
3, 4, 5      | Spring
6, 7, 8      | Summer
9, 10, 11    | Autumn


## Task 6:

There must now be implemented a method which counts up to the class how many have birthday in each season. This method does not return anything, but just write the result out in the console 

Where should this method lie?

 
hint. see if you can code it via a Linq statement

Call the method.

 
Remember to commit and push to the Git repo (GitHub). :octocat:

 

## Extras: Task 7

Try to ensure that there cannot enter a birth month which lies outside the interval 1-12

 


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
Husk at comitte og pushe til dit Git repo(GitHub). :octocat:


## Opgave 2:
Tilføj en ny klasse “KlasseRum”, med følgende properties.

* string KlasseNavn
* List\<Studerende> Klasseliste
* DateTime SemesterStart

Opret en default constructor.


Husk at comitte og pushe til dit Git repo (GitHub). :octocat:


## Opgave 3:

Vi skal nu tilføje data. Det gør vi i Main metoden.

Opret en instans af KlasseRum 

KlasseNavn: 3B

SemesterStart: 4-9-2018 

Tilføj dig selv og dem du sidder ved siden af i listen over studerende


Husk at comitte og pushe til dit Git repo (GitHub). :octocat:


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

Husk at comitte og pushe til dit Git repo (GitHub). :octocat:


## Ekstra: Opgave 7
Prøv at sikre at der ikke kan indtastes en fødselsmåned som ligger udenfor intervallet 1-12


