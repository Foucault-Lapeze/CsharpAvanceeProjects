using PooZoo.model;

namespace POO.animeaux;

public class Lion : Animal {
    private string name {get; set;}
    private int age { get; set; }
    
    public override string crier() {
        return "rugissement Lion";
    }
    
    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }
}