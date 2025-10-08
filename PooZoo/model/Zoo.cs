namespace PooZoo.model;

public class Zoo {

    public string name { get; set; }
    public string adresse { get; set; }

    public Zoo(string name, string adresse)
    {
        this.name = name;
        this.adresse = adresse;
    }
}