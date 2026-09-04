using System;
using System.Collections.Generic;
using System.Text;

namespace LaVieDeBob
{
    public class Emploi
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Carriere { get; set; }
        public int Salaire { get; set; }


        public Emploi() 
        {
            Prenom = string.Empty;
            Nom = string.Empty; 
            Carriere = string.Empty;
            Salaire=0;    
        }

        public Emploi(string prenom, string nom, string carriere, int salaire)
        {
            Prenom = prenom;
            Nom = nom;
            Carriere = carriere;
            Salaire = salaire;
        }


        public int Paie(int NbHeureTravailler=1)
        {
            return Salaire* NbHeureTravailler;
        }


        public void AugSalaire(int augementation)
        {
            Salaire += augementation;
        }
    }
}
