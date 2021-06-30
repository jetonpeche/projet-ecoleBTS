using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetE4
{
    public class MedicamentClass
    {
        private string _id;
        private string _depotLegal;
        private string _nom_commercial;
        private string prix_echantillon;
        private string lib_famille;



        public string Id { get => _id; set => _id = value; }
        public string DepotLegal { get => _depotLegal; set => _depotLegal = value; }
        public string Nom_commercial { get => _nom_commercial; set => _nom_commercial = value; }
        public string Prix_echantillon { get => prix_echantillon; set => prix_echantillon = value; }
        public string Lib_famille { get => lib_famille; set => lib_famille = value; }

        public MedicamentClass(string id, string depotL, string nomCom, string prix, string libFamille)
        {
            Id = id;
            DepotLegal =depotL;
            Nom_commercial = nomCom;
            Prix_echantillon = prix;
            Lib_famille = libFamille;
        }
    }
}
