using System;

abstract class Account{
    public string Number {get;set;}
    public double Balance {get;set;}
    public Person Owner {get;set;}

    public Account(){
        
    }

    public void Withdraw(double amount){
        Balance -= amount;
    }
    public void Deposit(double amount){
        Balance += amount;
    }

}