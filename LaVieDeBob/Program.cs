using LaVieDeBob;
using LaVieDeBob.model;

Personne p1 =new Personne();





string choix;

do
{


    Console.WriteLine("--------------------------------------");
    Console.WriteLine($"le temps est maintenant = {temps}");
    Console.WriteLine("1 wazaaa");
    Console.WriteLine("2 Voir solde");
    Console.WriteLine("3 travailler (8h)");
    Console.WriteLine("4 dormir (8h)");
    Console.WriteLine("5 passer le temps (2h)");
    Console.WriteLine("6 nourrir Roboto");
    Console.WriteLine("7 nourrir Mitaine");
    Console.WriteLine("q quitter");
    Console.WriteLine("--------------------------------------");
    choix = Console.ReadLine();

    switch (choix)
    {
        case "1":
            Console.WriteLine("WAZZAAAAAA");
            break;
        case "2":

            break;
    }

} while (choix != "q");




///
/// class "nom" : "nom du parent"
/// public "type" "nom d'un paramètre" {get:}
///