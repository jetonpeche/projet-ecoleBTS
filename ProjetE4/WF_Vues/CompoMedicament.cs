using System;
using System.Windows.Forms;

namespace ProjetE4
{
    public partial class CompoMedicament : Form
    {

        private bdd Bdd;
        private string idMedic;

        private string idComposerSelectionne;

        public CompoMedicament(string idMedic)
        {
            try
            {
                InitializeComponent();

                Bdd = new bdd();

                this.idMedic = idMedic;
            }
            catch(Exception ex)
            {
                if (Erreur.ErreurHttp())
                {
                    this.Close();
                }
            }
        }

        #region evenement
        // charge la comboxBox et tableau
        private void CompoMedicament_Load(object sender, EventArgs e)
        {
            try
            {
                cbx_composant.DataSource = Bdd.ListeComposant();
                ChargerTableau();
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

        // recuperere l'ID du composant de la ligne du tableau selectionne et affiche le nom du composant
        private void dataGridView_compoMedic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CompositionMedicament selectComposer = dataGridView_compoMedic.SelectedRows[0].DataBoundItem as CompositionMedicament;

            lbl_composerSelectionne.Text = selectComposer.ToString();
            idComposerSelectionne = selectComposer.RecupereId();
        }

        // modifier composer medicament
        private void btn_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                // recupere le composant selectionné dans la comboBox
                Composant idNouveauComposer = cbx_composant.SelectedItem as Composant;

                if(idComposerSelectionne != null && lbl_composerSelectionne.Text != "")
                {
                    if(idNouveauComposer.RecupererId() != null)
                    {
                        Bdd.ModifierComposerMedic(idComposerSelectionne, idNouveauComposer.RecupererId(), idMedic);
                        ChargerTableau();
                    }
                    else
                    {
                        MessageBox.Show("Veuillez choisir un nouveau composant dans la liste deroulante");
                    }                   
                }
                else
                {
                    MessageBox.Show("Veuillez selectionner un composer du medicament");
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

        // supprime un composer du medicament
        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                Bdd.SuppComposerMedic(idComposerSelectionne, idMedic);
                ChargerTableau();
            }
            catch (Exception ex)
            {
                if (Erreur.ErreurHttp())
                {
                    this.Close();
                }
            }
        }
        #endregion

        private void ChargerTableau()
        {
            dataGridView_compoMedic.DataSource = Bdd.ListeCompoMedic(idMedic);
        }
    }
}
