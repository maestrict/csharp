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


//avec une boucle for calculer les x premier nombre premier
System.Console.WriteLine("Donner un nombre");
int nombre2 = int.Parse(Console.ReadLine());
int test=0;
int boucle=1;
while(test < nombre2){
    int result = nbPremier(boucle);
    if(result>0){
        System.Console.WriteLine(result);
        test++; 
    };
    boucle++;
    
}
static int nbPremier(int n){
    int test2 =0;
    for(int i=2; i<=n;i++){
        if(n%i==0){
            test2++;
        }
    }
    if(test2==1){
        if(n==2){
            return 0;
        }else{
            return n;
        }
        
    }else{
        return 0;
    }
    
}
