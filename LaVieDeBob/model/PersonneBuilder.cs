using System;
using System.Collections.Generic;
using System.Text;


//Avec l'aide de Luca et medium
//https://medium.com/@lakstutor/c-builder-pattern-constructing-objects-step-by-step-97b583246599

namespace LaVieDeBob.model
{
    public class PersonneBuilder
    {
        private Personne p1= new Personne();
        public PersonneBuilder ajoutPreNom(string prenom)
        {
            p1.Prenom= prenom ;
            return this;
        }

        public PersonneBuilder ajoutNom(string nom)
        {
            p1.Nom = nom;
            return this;
        }

        public PersonneBuilder ajoutAnimal(Animal[] animaux)
        {
            p1.Animaux = animaux;
            return this;
        }

        public PersonneBuilder ajoutEmploi(string emploi)
        {
            p1.Emploi = emploi;
            return this;
        }

        public PersonneBuilder ajoutAdresse(Adresse adresse)
        {
            p1.Adresses = adresse;
            return this;
        }

        public PersonneBuilder ajoutAge(int age)
        {
            p1.Age = age;
            return this;
        }



        public virtual Personne Build() 
        {
            return p1;
        }
    }
}
