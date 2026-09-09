using System;
using System.Collections.Generic;
using System.Text;

namespace LaVieDeBob.model
{
    public class Adresse
    {
        private string nomrue;

        public string Nomrue
        {
            get { return nomrue; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Le nom de rue doit avoir des lettre ");
                }
                nomrue = value;
            }
        }


        private int numeromaison;

        public int Numeromaison
        {
            get { return numeromaison; }
            set
            {
                if (value  <=0)
                {
                    throw new ArgumentOutOfRangeException("le numéro de maison doit être positif");
                }
                numeromaison = value;
            }
        }

        public Adresse(string nom, int numero)
        {
            Nomrue = nom;
            Numeromaison = numero;
        }
    }
}


