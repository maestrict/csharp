abstract class Account{

    public string Number {get; set;}
    public double Balance {get; private set;}
    public Person Owner {get; set;}

    public Account(string number, double balance, Person owner){
        Number = number;
        Balance = balance;
        Owner = owner;
    }
    public abstract void Withdraw();
    public void Deposit(double amount){
        Balance += amount;
    }



}