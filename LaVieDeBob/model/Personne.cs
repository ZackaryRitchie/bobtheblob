using LaVieDeBob.model;
using System;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text.RegularExpressions;


namespace LaVieDeBob
{

	public class Personne
	{
		
		public Animal[] Animaux { get; set; }
		public string Adresse { get; set; }

		private string prenom;

		public string Prenom
		{
			get { return prenom; }
			set { 
				if (string.IsNullOrEmpty(value) )
				{
					throw new ArgumentException("Le Prénom doit être un string");
				}
				prenom = value; 
			}
		}


        private string nom;

        public string Nom
        {
            get { return nom; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Le nom doit être un string");
                }
                nom = value;
            }
        }


        private string emploi;

        public string Emploi
        {
            get { return emploi; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("L'emploi doit être un string");
                }
                emploi = value;
            }
        }

		private int age;

		public int Age
		{
			get { return age; }
			set { 
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException(nameof(age), age, "L'age doit être positif");
                }
				age = value; 
			}
		}





		public Personne()
		{
			Prenom = "";
			Nom = "";
			Animaux = [];
			Emploi = "aucun";
			Adresse = "";
			Age = 0;

		}

		public Personne(string prenom, string nom, Animal[] animaux,string emploi, string adresse,int age) 
		{
            Prenom = prenom;
            Nom = nom; 
			Animaux=animaux;
			Emploi = emploi;
			Adresse=adresse;
			Age=age;

		}


		public Personne(string prenom,int age)
		{
			Prenom=prenom;
			Age = age;
		}


		public void Tempsavence(int annee=1)
		{
			if (annee <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(annee), annee, "L'année doit être positif");
			}
            Age += annee;

        }



        //public override string ToString()
        //{
        //    return $"nom:{Prenom} {Nom}, Age: {Age} ans, Adresse: {Adresse}, Emploi: {Emploi}, Animaux de compagnie: {Animaux}";
        //}
	}
}


// || Regex.IsMatch(value, @"^[A-Za-z]\d[A-Za-z] ?\d[A-Za-z]$")