namespace PooZoo.model;

//Class abstraite animal
public abstract class Animal {
    
    //méthode abstraite crier (chaque animal doit la définir
    public abstract string crier();
    
    //méthode concrète dormir (commun pour chaque animeaux)
    public string dormir()
    {
        return "ZZzzzZZ";
    }

}