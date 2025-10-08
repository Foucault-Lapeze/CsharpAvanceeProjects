using PooZoo.model;

namespace PooZoo.animeaux;


//héritage de la classs animal
public class Chien : Animal { 
    
    public string name { get; set; }
    public int age {get; set;}
    
    //methode crier propre aux chiens
    public override string crier() {
        return "Woaf Woaf";
    }
    
    public Chien(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}