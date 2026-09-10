using LaVieDeBob.model;
using System;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text.RegularExpressions;


namespace LaVieDeBob
{

	public class Personne
	{
		
		public Animal[] Animaux { get; set; }
		public Adresse Adresses { get; set; }

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
					emploi = "aucune";
				}
				else 
				{ 
                emploi = value;
                }
            }
        }

		private int age;

		public int Age
		{
			get { return age; }
			set {
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException(nameof(age), age, "L'age doit être positif");
				}
				else if (value is int)
				{
					age = value;
				}
				else
				{
					age = 0;
				}
			}
		}





		public Personne()
		{
			Prenom = "";
			Nom = "";
			Animaux = [];
			Emploi = "aucun";
			Adresses =new Adresse("a",1);
			Age = 0;

		}

		public Personne(string prenom, string nom, Animal[] animaux,string emploi, Adresse adresse,int age) 
		{
            Prenom = prenom;
            Nom = nom; 
			Animaux=animaux;
			Emploi = emploi;
			Adresses=adresse;
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



        public override string ToString()
        {
            return $"nom:{Prenom} {Nom}, Age: {Age} ans, Adresse: {Adresses}, Emploi: {Emploi}, Animaux de compagnie: {Animaux}";
        }
	}
}


// || Regex.IsMatch(value, @"^[A-Za-z]\d[A-Za-z] ?\d[A-Za-z]$")