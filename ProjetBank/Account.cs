public abstract class Account{

    public string Number {get; set;}
    public double Balance {get; protected set;}
    public Person Owner {get; set;}

    public Account(string number, double balance, Person owner){
        Number = number;
        Balance = balance;
        Owner = owner;
    }
    public abstract void Withdraw(double amount);
    public void Deposit(double amount){
        Balance += amount;
    }

}