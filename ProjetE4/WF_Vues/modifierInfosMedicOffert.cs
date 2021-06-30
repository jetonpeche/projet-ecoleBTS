using System;
using System.Windows.Forms;

namespace ProjetE4
{
    public partial class modifierInfosMedicOffert : Form
    {
        private bdd Bdd;
        private MedicamentOffertInfos medicamentInfos;

        public modifierInfosMedicOffert(string idMedicOffert)
        {
            try
            {
                if (idMedicOffert != "")
                {
                    InitializeComponent();

                    Bdd = new bdd();
                    medicamentInfos = new MedicamentOffertInfos();

                    medicamentInfos = Bdd.ListeInfosMedicOffert(idMedicOffert);
                }
                else
                {
                    this.Close();
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

        #region evenements
        // ferme le popUp
        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // charge les inputs et liste
        private void modifierInfosMedicOffert_Load(object sender, EventArgs e)
        {
            try
            {
                cbx_famille.DataSource = Bdd.ListeFamille();

                // enleve la selection par defaut de la comboBox
                cbx_famille.SelectedIndex = -1;

                // selection par defaut de la famille
                cbx_famille.SelectedText = medicamentInfos.ToString();


                txb_nom.Text = medicamentInfos.Nom;
                txb_contreIndication.Text = medicamentInfos.ContreIndication;
                txb_effets.Text = medicamentInfos.Effets;
                txb_prix.Text = medicamentInfos.Prix;
                txb_qte.Text = medicamentInfos.Qte;
            }
            catch(Exception ex)
            {
                if (Erreur.ErreurHttp())
                {
                    this.Close();
                }
            }
        }

        private void btn_modiferInfos_Click(object sender, EventArgs e)
        {
            try
            {
                double prix;
                int qte;

                if (double.TryParse(txb_prix.Text, out prix))
                {
                    if (int.TryParse(txb_qte.Text, out qte))
                    {
                        Famille idFam = cbx_famille.SelectedItem as Famille;

                        if(idFam != null)
                        {
                            Bdd.ModifierInfosMedic(medicamentInfos.Id, idFam.RecupererId(), txb_nom.Text, txb_contreIndication.Text, txb_effets.Text, txb_prix.Text, txb_qte.Text);

                            MessageBox.Show("Modification effectuer");
                        }
                        else
                        {
                            MessageBox.Show("Faite derouler la liste pour selectionner la famille");
                        }                       
                    }
                    else
                    {
                        MessageBox.Show("La quantité doit etre un nombre entier");
                    }
                }
                else
                {
                    MessageBox.Show("Le prix doit etre de type numerique");
                }
            }
            catch(Exception ex)
            {
                if(Erreur.ErreurHttp())
                {
                    this.Close();
                }
            }
        }
        #endregion
    }
}
