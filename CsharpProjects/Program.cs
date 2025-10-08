using System;

string chaineDeCalcul = "";

while (chaineDeCalcul != "q")
{
    Console.WriteLine("Votre calcul : (q pour quitter)");

    chaineDeCalcul = Console.ReadLine();
    if(chaineDeCalcul == "q")
    {
        break;
    }

    string nombre1str = "";
    string nombre2str = "";
    string operateur = "";
    bool nombre1Finded = false;

    decimal resultat = 0;

    foreach (char caractere in chaineDeCalcul)
    {
        if (char.IsDigit(caractere))
        {
            if (!nombre1Finded)
            {
                nombre1str += caractere;
            }
            else
            {
                nombre2str += caractere;
            }
        }
        else
        {
            if (nombre1Finded)
            {
                resultat = FaireCalcul(nombre1str, nombre2str, operateur);
                nombre1str = resultat.ToString();
                operateur = caractere.ToString();
                nombre2str = "";
            }
            else
            {
                operateur = caractere.ToString();
                nombre1Finded = true;
            }
        }
    }

    resultat = FaireCalcul(nombre1str, nombre2str, operateur);

    Console.WriteLine($"Résultat : {resultat}");
}


decimal FaireCalcul(string n1, string n2, string op)
{
    try
    {

        decimal a = decimal.Parse(n1);
        decimal b = decimal.Parse(n2);

        return op switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => b != 0 ? a / b : throw new DivideByZeroException(),
            _ => throw new InvalidOperationException($"Opérateur inconnu : {op}")
        };
    }
    catch
    {
        Console.WriteLine("Calcul impossible.");
        return 0;
    }
}