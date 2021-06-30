namespace ProjetE4
{
    public class Rapport_visite
    {
        private string _dateRapport;
        private string _nomPraticien;
        private string _prenomPraticien;
        private string _coef;
        private string _nomVisiteur;
        private string _prenomVisiteur;
        private string _motif;
        private string _bilan;

        public string DateRapport { get => _dateRapport; set => _dateRapport = value; }
        public string NomPraticien { get => _nomPraticien; set => _nomPraticien = value; }
        public string PrenomPraticien { get => _prenomPraticien; set => _prenomPraticien = value; }
        public string Coef { get => _coef; set => _coef = value; }
        public string NomVisiteur { get => _nomVisiteur; set => _nomVisiteur = value; }
        public string PrenomVisiteur { get => _prenomVisiteur; set => _prenomVisiteur = value; }
        public string Motif { get => _motif; set => _motif = value; }
        public string Bilan { get => _bilan; set => _bilan = value; }

        public Rapport_visite(string date, string nomP, string prenomP, string coef, string nomV, string prenomV, string motif, string bilan)
        {
            DateRapport = date;
            NomPraticien = nomP;
            PrenomPraticien = prenomP;
            Coef = coef;
            NomVisiteur = nomV;
            PrenomVisiteur = prenomV;
            Motif = motif;
            Bilan = bilan;
        }
    }
}
