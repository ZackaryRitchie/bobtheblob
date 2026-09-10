using LaVieDeBob;
using LaVieDeBob.model;

Chien roboto = new Chien("Roboto","Golden retriver",false, DateTime.Now);
Chat mitaine = new Chat("Mitaine","Persian",false, DateTime.Now);
Adresse bobAd = new Adresse("rue la fontaine", 54);


Personne p1 = new PersonneBuilder()
    .ajoutPreNom("BoB")
    .ajoutNom("The Blob")
    .ajoutAnimal([roboto,mitaine])
    .ajoutEmploi("Programmeur")
    .ajoutAdresse(bobAd)

    .Build();

Compte c1 = new Compte(p1.Prenom,p1.Nom);
Emploi e1 = new Emploi(p1.Prenom, p1.Nom,p1.Emploi,22.50);


DateTime temps = DateTime.Now;
string choix;

do
{
    Console.WriteLine(roboto.AvertirFaim());
    Console.WriteLine(mitaine.AvertirFaim());
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
            Console.WriteLine(c1.Solde+"$");
            break;
        case "3":
            temps=Utilisataire.Passerletemps(temps, 8);
            c1.AjouteArgent(e1.Paie(8));
            break;
        case "4":
            Console.WriteLine("ZZZzzzz ZZZzzzz ZZZzzzz");
            temps=Utilisataire.Passerletemps(temps, 8);
            break;
        case "5":
            Console.WriteLine("2 Hours Later");
            temps = Utilisataire.Passerletemps(temps, 2);
            break;
        case "6":
            if (roboto.Faim=false)
            {
                Console.WriteLine("Roboto n'a pas faim");
                break;
            } else{
                Console.WriteLine("Roboto a manger");
                roboto.Manger(temps);
                c1.SoustraireAregnet(8);
                break;

            }
        case "7":
            if (mitaine.Faim = false)
            {
                Console.WriteLine("Mitaine n'a pas faim");
                break;
            }
            else{
                Console.WriteLine("Mitaine a manger");
                mitaine.Manger(temps);
                c1.SoustraireAregnet(5);
                break;

            }
            
    }   

} while (choix != "q");




///
/// class "nom" : "nom du parent"
/// public "type" "nom d'un paramètre" {get:}
///