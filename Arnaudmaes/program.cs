
using arnaudmaes.Structures;


System.Console.WriteLine("Quelle mot?");

string mot = Console.ReadLine();
char[] array = new char[mot.Length];
for (int i = 0; i < mot.Length; i++) { 
         array[i] = mot[i];
         }
int tailleMot=mot.Length;
pendu pendu = new pendu(array, tailleMot);
System.Console.WriteLine(tailleMot);
while(pendu.generalCount != 0){
    System.Console.WriteLine("Quelle lettre?");
    string lettre = Console.ReadLine();
    System.Console.WriteLine(pendu.verif(lettre));
    System.Console.WriteLine(pendu.mot);
    System.Console.WriteLine(pendu.generalCount);
    if(pendu.life==0){
        System.Console.WriteLine("c'est perdu");
        break;
    }
}
if(pendu.generalCount==0){
    System.Console.WriteLine(("félicitation vous avez trouvé le mot!"));
}



