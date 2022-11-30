using System;

public class CurrentAccount : Account
{ 

    public double CreditLine {get;}

    public CurrentAccount(string number, double balance, double creditline, Person owner) : base(number,balance,owner){
        CreditLine = creditline;
    }

    public override void Withdraw(double amount)
    {
        Balance -= amount;
    }


}