using System;

class Person{

    public string Name { get;set;}
    public string Lastname { get;set;}
    public DateTime Birthdate { get;set;}

    public Person(string name, string lastname, DateTime birtname){
        Name = name;
        Lastname = lastname;
        Birthdate = birtname;
    }
}