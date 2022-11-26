
Person pers1 = new Person("Maes","Arnaud",new DateTime(1995,01,30));
Account account1 = new Saving("56655", 1566,pers1);
System.Console.WriteLine(account1.Balance);
try
{
   account1.Withdraw(10000); 
}
catch(Exception ex)
{
    System.Console.WriteLine("tu es pauvre!");
}



System.Console.WriteLine(account1.Balance);
//System.Console.WriteLine(account1.DateLastWithdraw);