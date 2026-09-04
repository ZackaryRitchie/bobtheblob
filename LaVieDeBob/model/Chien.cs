using System;
using System.Collections.Generic;
using System.Text;

namespace LaVieDeBob.model
{
    public class Chien : Animal
    {
        public Chien(
            string nom,
            string type,
            bool faim,
            DateTime derniersouper) 
        {
            Nom=nom;
            Type=type;
            Cout = 8;
            TempsEntreSouper = new TimeSpan(10,0,0);
        }




    }
}
