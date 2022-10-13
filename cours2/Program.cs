// int a = Convert.ToInt32("78");

// int b = int.Parse("3");

// int c;
// var response = int.Parse(Console.ReadLine());

// if(response ==false)
//    System.Console.WriteLine("ce n'est pas un nombre");
// else
// System.Console.WriteLine(response + a);

// int nbrDeFichierTotal = 208;
// int nbrDeFichierCopier = 56;

// float pourcent = ((float)100 / nbrDeFichierTotal * nbrDeFichierCopier);
// System.Console.WriteLine(pourcent);
// //Exercice 1
// System.Console.WriteLine("Donner le premier nombre");
// var response = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Donner le deuxième nombre");
// var response2 = int.Parse(Console.ReadLine());
// int addition = response + response2;

// System.Console.WriteLine("l'addition est de " + addition );

// //Exercice 2
// float a;
// float b;

// System.Console.WriteLine("Donner le premier nombre");
// var response = float.TryParse(Console.ReadLine(), out a);
// System.Console.WriteLine("Donner le deuxième nombre");
// var response2 = float.TryParse(Console.ReadLine(), out b);

// if (response ==false)
//     System.Console.WriteLine("le premier nombre n'est pas un nombre");
// else if(response2 ==false)
//     System.Console.WriteLine("le deuximème nombre n'est pas un nombre");
// else
//     System.Console.WriteLine(a + b);
// System.Console.WriteLine("Donnez un entier");
// var response = int.Parse(Console.ReadLine());
// if(response%2 ==0)
//     System.Console.WriteLine("le nombre est pair");
// else
//     System.Console.WriteLine("le nombre est impair");
// System.Console.WriteLine("Donnez premier chiffre");
// var response1 = float.Parse(Console.ReadLine());
// System.Console.WriteLine("Donnez deuxième chiffre");
// var response2 = float.Parse(Console.ReadLine());

// float division = response1/response2;
// float modulo = response1 % response2;
// int nbrDivision = 0;
// while ((response1 - response2) >= 0){
//     response1 -= response2;
//     nbrDivision ++;
// }
// System.Console.WriteLine("Division entière :" + nbrDivision + ", Modulo :" + modulo + ", Division :" + division);

System.Console.WriteLine("Donner compte IBAN");
string response = Console.ReadLine();
//int a = int.Parse(response.Substring(0,9));
//System.Console.WriteLine(a);
int test=0;
for(int i=0;i<response.Length;i++ ){
    test = test + int.Parse(response.Substring(i,1));
    //System.Console.WriteLine(int.Parse(response.Substring(i,1)));
}
System.Console.WriteLine(test);

if(test % 9 == int.Parse(response.Substring(response.Length-2,2))){
    System.Console.WriteLine("le code est correct");
}
else{
    System.Console.WriteLine("le code n'est pas correct");
}

// string author = "Name: Mahesh Chand, Book: C# Programming, Publisher: C# Corner, Year: 2020";    
// string[] authorInfo = author.Split(", ");    
// foreach (string info in authorInfo)    
// {    
//     Console.WriteLine("   {0}", info.Substring(info.IndexOf(": ") + 1));    
// }

