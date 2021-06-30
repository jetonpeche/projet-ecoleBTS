using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetE4
{
    class Visiteur
    {
        private string _id;
        private string _nom;
        private string _prenom;

        public string Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }

        public Visiteur(string id, string nom, string prenom)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
        }

        public string RecupererId()
        {
            return Id;
        }

        public override string ToString()
        {
            return Nom + " " + Prenom;
        }
    }
}
