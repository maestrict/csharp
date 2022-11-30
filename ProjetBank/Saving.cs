using System;

class Saving : Account
{

    public DateTime DateLastWithdraw {get;set;}

    public Saving(string number, double balance, Person owner) : base(number,balance,owner){
    
    }

    public override void Withdraw(double amount){
        Balance -= amount;
        DateLastWithdraw = DateTime.Now;
    }

}