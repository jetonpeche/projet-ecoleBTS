using System;
using System.Windows.Forms;

namespace ProjetE4
{
    public partial class Accueil : Form
    {
        private Admin admin;
        private bdd Bdd;

        public Accueil(Admin a)
        {
            InitializeComponent();

            if(a != null)
            {
                Bdd = new bdd();
                admin = new Admin();
                admin = a;
            }
            else
            {
                MessageBox.Show("Bien tenter :) !" + Environment.NewLine + "Mais il faut se connecter petit galopin !");
            }
        }

        #region evenement
        // ferme la fenetre
        private void btn_deconnexion_Click(object sender, EventArgs e)
        {
            admin = null;
            this.Close();
        }

        // ajout d'un composant
        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_nomComposant.Text != "")
                {
                    string nomComposant = tb_nomComposant.Text;

                    Bdd.AjoutComposant(nomComposant);
                    tb_nomComposant.Text = "";

                    MessageBox.Show("Ajout effectué");
                }
                else
                {
                    if (Erreur.ErreurHttp())
                    {
                        this.Close();
                    }
                }
            }
            // erreur http
            catch (Exception ex)
            {
                if (Erreur.ErreurHttp())
                {
                    this.Close();
                }
            }
        }

        // Ouvre page rapport
        private void lblk_rapport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rapport rapport = new Rapport();
            rapport.ShowDialog();
        }

        // ouvre page medicament
        private void lblk_medicament_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Medicament medicament = new Medicament();
            medicament.ShowDialog();
        }

        #endregion

    }
}
