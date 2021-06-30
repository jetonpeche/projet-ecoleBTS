using System;
using System.Windows.Forms;

namespace ProjetE4
{
    public partial class AjouterRapport : Form
    {
        private bdd Bdd;

        public AjouterRapport()
        {
            InitializeComponent();
            
            Bdd = new bdd();
        }

        #region evenement
        // charge les comboBox au demarage de la fenetre
        private void AjouterRapport_Load(object sender, EventArgs e)
        {
            try
            {
                cbx_praticien.DataSource = Bdd.ListePratiicien();
                cbx_visiteur.DataSource = Bdd.ListeVisiteur();
            }
            catch(Exception ex)
            {
                if (Erreur.ErreurHttp())
                {
                    this.Close();
                }
            }
        }

        // Racupere les info du formulaire pour ajour un rapport dans la dbb
        private void btn_ValiderPraticien_Click(object sender, EventArgs e)
        {
            try
            {
                // recuperation de l'Id du praticien et visiteur
                Praticien pr = cbx_praticien.SelectedItem as Praticien;
                Visiteur vi = cbx_visiteur.SelectedItem as Visiteur;

                if (txb_motif.Text != "" && txb_bilan.Text != "" && pr.RecupererId() != null && vi.RecupererId() != null)
                {
                    // textBoxs
                    string motif = txb_motif.Text;
                    string bilan = txb_bilan.Text;

                   Bdd.AjoutRapport(pr.RecupererId(), vi.RecupererId(), motif, bilan);
                   this.Close();
                }
                else
                {
                    MessageBox.Show("Veuillez selectionner un visiteur ou / et praticien");
                }
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
        #endregion
    }
}