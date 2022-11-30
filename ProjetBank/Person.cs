using System;

class Person{

    public string Firstname{get;set;}
    public string Lastname{get;set;}
    public DateTime BirthDate{get;set;}

    public Person(string firstname, string lastname, DateTime birthDate){
        Firstname = firstname;
        Lastname = lastname;
        BirthDate = birthDate;
    }


}