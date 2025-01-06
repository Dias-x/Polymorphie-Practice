using System;
using Praxis_Polymorphismus;

class Program
{
    static void Main(string[] args)
    {
        //Objekte erstellen
        Person dias = new Person("Dias", "Helder");
        Person alves = new Person("Alves", "Andre");
        
        //Methode abrufen, mit Überladene Methode
        dias.Greet(alves);
        
        

    }
}