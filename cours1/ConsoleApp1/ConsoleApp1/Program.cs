// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

class Exemple
{
    static void Main()
    {
        System.Console.WriteLine("test : " + assignVarA());
        Console.WriteLine("fonction A :" + assignVarB(5));
        Console.WriteLine(nom);
        String test = new String("test123");
        Console.WriteLine(test) ;

        RunExemple();

    }

    const string nom = "Ben";
   
    static int assignVarA()
    {
        int a = 2;
        return assignVarB(a);
    }

    static int assignVarB(int a)
    {
        int b = a+10;
        return b;
    }

    static void RunExemple()
    {
        // string format
        var a = "A";
        var b = "lors";
        var output = $"premier {a} deuxieme {b}";
        string format = string.Format("premier {0} deuxieme {1}", a, b);

        Console.WriteLine(output);
        Console.WriteLine(format);
    }
   

}













