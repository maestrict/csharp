
Person pers1 = new Person("Maes","Arnaud",new DateTime(1995,01,30));
Account account1 = new Saving("56655", 1566,pers1);
System.Console.WriteLine(account1.Balance);
account1.Withdraw(100);
System.Console.WriteLine(account1.Balance);
//System.Console.WriteLine(account1.DateLastWithdraw);