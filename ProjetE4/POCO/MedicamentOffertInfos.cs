using System;


namespace ProjetE4
{
    class MedicamentOffertInfos
    {
        private string _id;
        private string _nom;
        private string _effets;
        private string _contreIndication;
        private string _famille;
        private string _idFamille;

        private string _qte;
        private string _prix;

        public string Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Effets { get => _effets; set => _effets = value; }
        public string ContreIndication { get => _contreIndication; set => _contreIndication = value; }
        public string Famille { get => _famille; set => _famille = value; }
        public string IdFamille { get => _idFamille; set => _idFamille = value; }
        public string Qte { get => _qte; set => _qte = value; }
        public string Prix { get => _prix; set => _prix = value; }

        public MedicamentOffertInfos()
        { }

        public string RecupererIdFamille()
        {
            return Convert.ToString(IdFamille);
        }

        public void InfosMedic(string id, string nom, string effets, string contreIndication, string qte, string prix, string idFamille, string famille)
        {
            Id = id;
            Nom = nom;
            Effets = effets;
            ContreIndication = contreIndication;
            Qte = qte;
            Prix = prix;
            IdFamille = idFamille;
            Famille = famille;
        }

        public override string ToString()
        {
            return IdFamille + " " + Famille;
        }

    }
}
