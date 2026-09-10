using System;
using System.Collections.Generic;
using System.Text;


//Avec l'aide de Luca et medium
//https://medium.com/@lakstutor/c-builder-pattern-constructing-objects-step-by-step-97b583246599

namespace LaVieDeBob.model
{
    public class PersonneBuilder
    {
        private string Prenom;
        private string Nom;
        private int Age;
        private Animal[] Animaux;
        private Adresse Adresses;
        private string Emploi;

        public PersonneBuilder ajoutPreNom(string prenom)
        {
            Prenom= prenom ;
            return this;
        }

        public PersonneBuilder ajoutNom(string nom)
        {
            Nom = nom;
            return this;
        }

        public PersonneBuilder ajoutAnimal(Animal[] animaux)
        {
            Animaux = animaux;
            return this;
        }

        public PersonneBuilder ajoutEmploi(string emploi)
        {
            Emploi = emploi;
            return this;
        }

        public PersonneBuilder ajoutAdresse(Adresse adresse)
        {
            Adresses = adresse;
            return this;
        }

        public PersonneBuilder ajoutAge(int age)
        {
            Age = age;
            return this;
        }



        public virtual Personne Build() 
        {
            return new Personne(Prenom,Nom,Animaux,Emploi,Adresses,Age);
        }
    }
}
