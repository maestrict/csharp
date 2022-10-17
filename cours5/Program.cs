using System;


Personne pers1 = new Personne("arnaud", "maes", new DateTime(1995,01,30));
Personne pers2 = pers1;
pers2.Name = "jean paul";
System.Console.WriteLine($"Nom : {pers1.Name} Prénom {pers1.Lastname}");
Personne pers3 = new Personne("machin", "machin",  new DateTime(1995,01,30));
System.Console.WriteLine($"Nom : {pers3.Name} Prénom {pers3.Lastname}");
CurrentAccount account1 = new CurrentAccount("1452", 100, 345, pers1);
System.Console.WriteLine($"Le compte de {account1.Owner.Name} est de {account1.Balance}");
account1.Deposit(50);
System.Console.WriteLine($"Le compte de {account1.Owner.Name} est de {account1.Balance}");
account1.Withdrawal(50);
System.Console.WriteLine($"Le compte de {account1.Owner.Name} est de {account1.Balance}");
Bank bank1 = new Bank("BNP", account1);
System.Console.WriteLine($"{bank1.Compte.Owner.Name}");


class Personne{

    public string Name { get;set;}
    public string Lastname { get;set;}
    public DateTime Birthdate { get;set;}

    public Personne(string name, string lastname, DateTime birtname){
        Name = name;
        Lastname = lastname;
        Birthdate = birtname;
    }
}
class CurrentAccount{
    public string Number { get;set;}
    public double Balance { get;set;}
    public double CreditLine { get;set;}
    public Personne Owner { get;set;}

    public CurrentAccount(string number, double balance, double creditline, Personne owner){
        Number = number;
        Balance = balance;
        CreditLine = creditline;
        Owner = owner;
    }

    public void Withdrawal(double amount){
        Balance = Balance - amount;
    }
    public void Deposit(double amount){
        Balance = Balance + amount;
    }
}

class Bank{
    public string Nom { get;set;}
    public CurrentAccount Compte { get;set;}

    public Bank(string nom, CurrentAccount compte){
        Nom = nom;
        Compte = compte;
    }
}
