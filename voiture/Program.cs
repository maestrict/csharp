/*
 * Décrivez une structure permettant de construire une voiture sur base de valeurs 
présentes dans des énumérations. 
Ensuite, ajoutez lui des méthodes utiles. 
Une fois construite, faites la rouler et affichez son état dans la console
*/

using Exercices_voiture.Enums;
using Exercices_voiture.Structures;

Voiture voiture = new Voiture(Marques.Renault,80,Carburants.Diesel);
voiture.Roule();
Console.WriteLine($"La {voiture.Marque} a {voiture.Kilometrage} km au compteur et roule au {voiture.Carburant}");

Voiture voiture2 = new Voiture(Marques.VW, 100, Carburants.Essence);
voiture2.Roule();
Console.WriteLine($"La {voiture2.Marque} a {voiture2.Kilometrage} km au compteur et roule au {voiture2.Carburant} sa puissance est de {voiture2.Puissance}");
voiture2.Roule();
Console.WriteLine($"La {voiture2.Marque} a {voiture2.Kilometrage} km au compteur et roule au {voiture2.Carburant} sa puissance est de {voiture2.Puissance}");
voiture2.boosterLaVoiture(150);

Console.WriteLine($"La {voiture2.Marque} a {voiture2.Kilometrage} km au compteur et roule au {voiture2.Carburant} sa puissance est de {voiture2.Puissance}");

