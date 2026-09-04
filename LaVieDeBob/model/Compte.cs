using System;
using System.Collections.Generic;
using System.Text;

namespace LaVieDeBob.model
{
    public class Compte
    {
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int Solde { get; set; }
    
        
        public Compte() 
        {
            Prenom = string.Empty;
            Nom = string.Empty;
            Solde = 0;
        }

        public Compte(string prenom, string nom)
        {
            Prenom=prenom;
            Nom = nom;
            Solde = 0;

        }


        public void AjouteArgent(int nbargent)
        {
            Solde += nbargent;
        }

        public void SoustraireAregnet(int nbargent)
        {
            Solde -= nbargent;
        }

        public int Consulter()
        {  return Solde; }
        
 


        public override string ToString()
        {
            return $"le compte de {Prenom} {Nom} as {Solde}$";
        }
    }
}
