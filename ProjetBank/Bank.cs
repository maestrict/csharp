using System;

public class Bank{

    public Dictionary<string, Account> Accounts {get; private set;}
    public string Name;
    
    public Bank(string name){
        Name = name;
        Accounts = new();
    }

    public void AddAccount(Account account){

        Accounts.Add(account.Number, account);

    }
    public void DeleteAccount(string number){
        Accounts.Remove(number);
    }


}