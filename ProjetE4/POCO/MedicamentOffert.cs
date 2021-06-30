using System;

namespace ProjetE4
{
    class MedicamentOffert
    {
        private string _id;
        private string _nom;
        private string _quantite;
        private string _depotLegal;

        public string Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Quantite { get => _quantite; set => _quantite = value; }
        public string DepotLegal { get => _depotLegal; set => _depotLegal = value; }

        public MedicamentOffert(string id, string nom, string qte, string depoL)
        {
            Id = id;
            Nom = nom;
            Quantite = qte;
            DepotLegal = depoL;
        }
    }
}
