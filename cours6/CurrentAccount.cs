using System;

class CurrentAccount : Account{

    public double CreditLine { get;set;}

    public CurrentAccount(string number, double balance, double creditline, Person owner){
        Number = number;
        Balance = balance;
        CreditLine = creditline;
        Owner = owner;
    }


}