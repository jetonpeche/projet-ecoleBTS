using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjetE4
{
    public partial class Rapport : Form
    {
        private bdd Bdd;

        public Rapport()
        {
            InitializeComponent();

            Bdd = new bdd();
        }

        #region evenement
        // Rempli le tableau au demarage de la page
        private void Rapport_Load(object sender, EventArgs e)
        {
            ActualiserTableau();

            // tableau en lecture seul
            dataGridView.ReadOnly = true;
        }

        // ferme la fenetre
        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ouvre popUp pour ajouter un rapport
        private void btn_ajoutRapport_Click(object sender, EventArgs e)
        {
            AjouterRapport ajouterRapport = new AjouterRapport();
            ajouterRapport.ShowDialog();
        }

        // bar de recherche nom praticien
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(txb_rechercheNomPrat.Text != "")
            {
                string recherche = txb_rechercheNomPrat.Text;

                try
                {
                    dataGridView.DataSource = Bdd.ListeRapport(recherche);
                }
                catch(Exception ex)
                {
                    if (Erreur.ErreurHttp())
                    {
                        this.Close();
                    }
                }
                
            }
            else
            {
                ActualiserTableau();
            }
        }

        // bar de recherche par date du rapport
        private void btn_validerRecherche_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/0[0-9]|1[0-9]|2[0-2])\/((19|20)\d\d)$");

            bool isValid = regex.IsMatch(txb_rechercheDate.Text.Trim());
            DateTime date;
            isValid = DateTime.TryParseExact(txb_rechercheDate.Text, "dd/MM/yyyy", new CultureInfo("fr-FR"), DateTimeStyles.None, out date);

            // si la date est inccorect
            if(!isValid)
            {
                MessageBox.Show("le format doit etre: dd/MM/yyyy");
            }
            // si la date est au bon format
            else
            {
                try
                {
                    dataGridView.DataSource = Bdd.ListeRapportDate(date);
                }
                catch(Exception ex)
                {
                    if (Erreur.ErreurHttp())
                    {
                        this.Close();
                    }
                }
                
            }
        }

        // remet le tableau à son etat d'origine
        private void btn_actualiserTableau_Click(object sender, EventArgs e)
        {
            ActualiserTableau();
        }
        #endregion

        #region methodes

        // alimente le tableau de rapport
        private void ActualiserTableau()
        {
            try
            {
                dataGridView.DataSource = Bdd.listRapport();
            }
            catch(Exception ex)
            {
                if (Erreur.ErreurHttp())
                {
                    this.Close();
                }
            }
            
        }
        #endregion
    }
}
