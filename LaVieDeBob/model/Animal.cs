using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LaVieDeBob.model
{
    public abstract class Animal
    {
        public string Nom { get; set; }
        public string Type {  get; set; }
        public bool Faim { get; set; }
        public int Cout { get; set; }
        public TimeSpan TempsEntreSouper { get; set; }
        public DateTime DernierSouper { get; set; }
    
    
        protected Animal() 
        {
            Faim = false;
            DernierSouper = DateTime.Now;



        }


        public  string AvertirFaim()
        {
            Random random= new Random();
            int randome=random.Next(1,2);

            if (randome==1 & (DernierSouper-DateTime.Now)< TempsEntreSouper)
            {
                return $"{Nom} a faim";

            }
            return $"{Nom} n'a pas faim";
        } 


        public void Manger(DateTime temps)
        {
            Faim = false;
            DernierSouper=temps;
        }
        
    
    }
}
