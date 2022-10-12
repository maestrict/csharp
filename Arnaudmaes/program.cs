// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// class program {

//     static char[] verif(char[] mot){
//         int count =0;
    
//         string lettre = Console.ReadLine();
//         System.Console.WriteLine(lettre);
//         for (int i = 0; i < mot.Length; i++) { 
//             if(mot[i] == lettre[0]){
//                 System.Console.WriteLine("c'est bon");
//                 count ++;
//             }else{
//                 System.Console.WriteLine("c'est pas bon");
//             }
//         }
//         if(count>0){
//             lettreTrouve[lettreTrouve.Length-1] = lettre[0];
//         }else{
//             lettrerater[lettrerater.Length-1]=lettre[0];
//         }
//         return mot;
//     }
//     static char[] construct(string mot){
//         char[] array = new char[mot.Length];

//         for (int i = 0; i < mot.Length; i++) { 
//                 array[i] = mot[i];
//             }
//         return array;
//     }
  
//     // Main Method
//     static public void Main(String[] args){
//         public static int life = 5;
//         char[] lettreTrouve = new char[100];
//         char[] lettrerater = new char[100];
//         bool test = false;
//         string mot = "test";
        
        
//         //arrayMot[arrayMot.Length-1] = "test";
//         char[] arrayMot = construct(mot);
        

//     }


// }

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



