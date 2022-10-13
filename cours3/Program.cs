// //suite fibonacci

// static int fibonacci(int n){
    
//     if(n == 0){
//         return 0;
//     }else if(n == 1){
//         return 1;
//     }else                   
//     {
//     int w; 
//     int u = 0;
//     int v = 1;
//     for(int i=2; i <= n; i++) 
//         {
//         w = u+v;
//         u = v;
//         v = w;
//         };
//     return v;  
//     }
    

// };

// for(int i=0;i<=25;i++){
//     System.Console.WriteLine("retour de la valeur de Fibonnacci en " + i + " est égale à " + fibonacci(i));
// }

// //factoriel d'un nombre entier en clavier

// System.Console.WriteLine("Donner un nombre");
// int nombre = int.Parse(Console.ReadLine());
// int test =1;
// for(int i=1;i<=nombre;i++){
//     test = test * i;
// }
// System.Console.WriteLine(test);


// //avec une boucle for calculer les x premier nombre premier
// System.Console.WriteLine("Donner un nombre");
// int nombre2 = int.Parse(Console.ReadLine());
// int test=0;
// int boucle=1;
// while(test < nombre2){
//     int result = nbPremier(boucle);
//     if(result>0){
//         System.Console.WriteLine(result);
//         test++; 
//     };
//     boucle++;
    
// }
// static int nbPremier(int n){
//     int test2 =0;
//     for(int i=2; i<=n;i++){
//         if(n%i==0){
//             test2++;
//         }
//     }
//     if(test2==1){
//         return n;
//     }else{
//         return 0;
//     }
    
// }

//écrire deux structures Celsius et Fahrenheit toutes deux ayant une vairable température de type "double".


// Celcius test = new Celcius(7.9);
// System.Console.WriteLine(test.température);
// Fahrenheit test2 = new Fahrenheit(7.9);
// System.Console.WriteLine(test2.température);


// public struct Celcius{
//      public double température;

//     public Celcius(double température){
//         this.température = température;
//     }


//     public override string ToString(){
//         return $"{température}";
//     }

// }

// public struct Fahrenheit{

//     public double température;

//     public Fahrenheit(double température){
//         this.température = température;
        
//     }

//     public override string ToString(){
//         return $"{température}";
//     }

// }


// //dans les structures Celcius et Fahrenheit, écrire la fonciton de conversion de l'une vers l'autre.


Celcius test = new Celcius(35.4);
System.Console.WriteLine($"Température est celcius {test.température} converti après en Fahrenheit {test.transform()}" );
Fahrenheit test2 = new Fahrenheit(80.5);
System.Console.WriteLine($"Température est fahrenheit {test2.température} converti après en celsius {test2.transform()}" );
System.Console.WriteLine(monTest(test.température));

static double monTest(double n){
    n = ((n*9/5)+32);
    return n;
}

public struct Celcius{
     public double température;

    public Celcius(double température){
        this.température = température;
    }

    public double transform(){
        double temp = (température*9/5+32);
        return temp;
    }


    public override string ToString(){
        return $"{température}";
    }

}

public struct Fahrenheit{

    public double température;

    public Fahrenheit(double température){
        this.température = température;
        
    }
    public double transform(){
    double temp = ((température-32)*5/9);  
    return temp;
    }

    public override string ToString(){
        return $"{température}";
    }

}


