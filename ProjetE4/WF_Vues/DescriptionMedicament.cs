using System;
using System.Windows.Forms;

namespace ProjetE4
{
    public partial class DescriptionMedicament : Form
    {
        private MedicamentInfos medicament;
        private bdd Bdd;

        public DescriptionMedicament(string idMedic)
        {
            InitializeComponent();

            medicament = new MedicamentInfos();
            Bdd = new bdd();

            try
            {
                medicament = Bdd.InfosMedic(idMedic);
            }
            catch(Exception ex)
            {
                if (Erreur.ErreurHttp())
                {
                    this.Close();
                }
            }
        }

        // ferme la fenetre
        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // affiche les effets et contre indication d'un medicament
        private void DescriptionMedicament_Load(object sender, EventArgs e)
        {
            txb_contreIndication.Text = medicament.ContreIndication;
            txb_effets.Text = medicament.Effets;
        }
    }
}
