using System;

class Saving : Account{
    public DateTime DateLastWithdraw {get;}

    public Saving(string number, double balance, Person owner){
        Number = number;
        Balance = balance;
        Owner = owner;
    }

    

}
