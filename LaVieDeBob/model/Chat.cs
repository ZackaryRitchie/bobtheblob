using System;
using System.Collections.Generic;
using System.Text;

namespace LaVieDeBob.model
{
    public class Chat : Animal
    {
        public Chat(
            string nom,
            string type,
            bool faim,
            DateTime derniersouper)
        {
            Nom = nom;
            Type = type;
            Cout = 5;
            TempsEntreSouper = new TimeSpan(8, 0, 0);
        }
    }
}