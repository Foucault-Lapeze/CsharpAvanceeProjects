using PooZoo.model;

namespace PooZoo.animeaux;

public class Chat : Animal {
    
    private string name;
    private int age;

    public override string crier()
    {
        return "Miaou Miapou";
    }

    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }
}