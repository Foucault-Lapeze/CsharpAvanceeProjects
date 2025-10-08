using POO.animeaux;
using PooZoo.animeaux;
using PooZoo.model;

//Création Zoo
Zoo zooPierre = new Zoo("Zoo Pierre", "12 Avenue André");
Zoo zooPaul = new Zoo("Zoo Paul",  "12 Avenue Jacque" );

//Création animeaux
Chien chien = new Chien("Phillipe", 3);

Lion lion = new Lion();
lion.Name = "Simba";

Chat chatRapido = new Chat();
chatRapido.Name = "Rapido";

Chat chatRazmo = new Chat();
chatRazmo.Name = "Razmo";

Console.WriteLine("Le chien " + chien.name + " à " + chien.age + " ans, il est au " + zooPierre.name + " entrain d'abaoyer "+ chien.crier());
Console.WriteLine("Le lion " + lion.Name + " est au " + zooPaul.name + " il est entrain de dormir "+ lion.dormir());
Console.WriteLine("Les chats " + chatRapido.Name + " et " + chatRazmo.Name + " sont entrain de jouer ensembles dans le " + zooPierre.name);