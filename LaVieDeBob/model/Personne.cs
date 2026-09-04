using System;


namespace LaVieDeBob
{

	public class Personne
	{
		public string Nom {  get; set; }
		public object[] Animaux { get; set; }
		public DateTime Date { get; set; }
		

		public Personne()
		{
			Nom = "";
			Animaux = [];
			Date =  DateTime.Now ;
		}

		public Personne(string nom, object[] animaux)
		{
			Nom = nom;
			Animaux=animaux;
			Date=  DateTime.Now;
		}
	}

}


