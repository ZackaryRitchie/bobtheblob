using System;
using System.Runtime.InteropServices.ObjectiveC;


namespace LaVieDeBob
{

	public class Personne
	{
		public string Prenom {  get; set; }
		public string Nom {  get; set; }
		public object[] Animaux { get; set; }
		public string Emploi { get; set; }
		public object Adresse { get; set; }
		public int Age { get; set; }

		public Personne()
		{
			Prenom = "";
			Nom = "";
			Animaux = [];
			Emploi = "aucun";
			Adresse = "";
			Age = 0;

		}

		public Personne(string prenom,string nom, object[] animaux, string adresse, int age)
		{
			Prenom= prenom;
			Nom = nom;
			Animaux=animaux;
			Emploi = "aucune";
			Adresse = adresse;
			Age=age;
		}

		public Personne(string prenom, string nom, object[] animaux,string emploi, object adresse,int age) 
		{
            Prenom = prenom;
            Nom = nom; 
			Animaux=animaux;
			Emploi = emploi;
			Adresse=adresse;
			Age=age;

		}


		public void tempsavence(int annee)
		{
			Age = Age + annee;
		}

        public override string ToString()
        {
            return $"nom:{Prenom} {Nom}, Age: {Age} ans, Adresse: {Adresse}, Emploi: {Emploi}, Animaux de compagnie: {Animaux}";
        }
	}
}


