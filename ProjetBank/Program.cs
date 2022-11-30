Person pers1 = new Person("Arnaud", "Maes", new System.DateTime(1995,01,30));
Person pers2 = new Person("Pauline", "Bafa", new System.DateTime(1997,05,15));

Saving saving1 = new Saving("1",1000,pers1);
CurrentAccount account1 = new CurrentAccount("2",12345,100,pers1);
CurrentAccount account2 = new CurrentAccount("1",12345,100,pers1);
CurrentAccount account3 = new CurrentAccount("3",12345,100,pers2);
Bank bank1 = new Bank("BNP");
bank1.AddAccount(account1);
bank1.AddAccount(account2);
bank1.AddAccount(account3);
bank1.DeleteAccount(account1.Number);
saving1.Withdraw(100);
System.Console.WriteLine($"le compte épargne de {saving1.Owner.Firstname} {saving1.Owner.Lastname} est de {saving1.Balance}");
saving1.Deposit(100);
System.Console.WriteLine($"le compte épargne de {saving1.Owner.Firstname} {saving1.Owner.Lastname} est de {saving1.Balance}");
System.Console.WriteLine(saving1.DateLastWithdraw);
string nomdefamille = "Maes";
string prenom = "Arnaud";

// for(int i=1;i<= bank1.Accounts.Count;i++){
//     if(bank1.Accounts[i].Owner.Firstname == prenom || bank1.Accounts[i].Owner.Lastname == nomdefamille){
//         System.Console.WriteLine($"Le solde du compte courant de {prenom} {nomdefamille} est de {bank1.Accounts[i].Balance}");
//     }
// }

foreach(KeyValuePair<string, Account> account in bank1.Accounts){
    if(account.Value.Owner.Firstname == prenom && account.Value.Owner.Lastname == nomdefamille){
         System.Console.WriteLine($"Le solde du compte courant {account.Key} de {account.Value.Owner.Firstname} {account.Value.Owner.Lastname} est de {account.Value.Balance}");
     }
}

