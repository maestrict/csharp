using System;

class Bank{

    public Dictionary<int, CurrentAccount> Accounts {get;}
    public string Name;
    
    public Bank(string name){
        Name = name;
        Accounts = new();
    }

    public void AddAccount(CurrentAccount account){
        if(Accounts.Count>0){
            Accounts.Add(Accounts.Count+1, account);
        }else{
            Accounts.Add(1,account);
        }
    }
    public void DeleteAccount(string number){

    }


}