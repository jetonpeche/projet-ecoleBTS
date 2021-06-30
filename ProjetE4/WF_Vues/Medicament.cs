using System;
using System.Windows.Forms;

namespace ProjetE4
{
    public partial class Medicament : Form
    {
        private bdd Bdd;

        public Medicament()
        {
            try
            {
                InitializeComponent();

                Bdd = new bdd();

                panel_medicament.Enabled = false;
                panel_medicament.Visible = false;

                panel_MedicamentOffert.Enabled = true;
                panel_MedicamentOffert.Visible = true;
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
        // ferme la fenetre
        private void btn_retourAccueil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // charge les tableaux et comboBox
        private void Medicament_Load(object sender, EventArgs e)
        {
            try
            {
                // --------------------- rempli dataGridView -------------------- //
                dataGridView_Medicament.DataSource = Bdd.ListeMedicament();
                dataGridView_medicOffert.DataSource = Bdd.ListeMedicamentOffert();

                // --------------------- rempli la comboBox --------------------- //
                cbx_famille.DataSource = Bdd.ListeFamille();
            }
            catch(Exception ex)
            {
                if (Erreur.ErreurHttp())
                {
                    this.Close();
                }
            }

        }

        // change de liste
        private void btn_changerListe_Click(object sender, EventArgs e)
        { 
                panel_medicament.Enabled = !panel_medicament.Enabled;
                panel_medicament.Visible = !panel_medicament.Visible;

                panel_MedicamentOffert.Enabled = !panel_MedicamentOffert.Enabled;
                panel_MedicamentOffert.Visible = !panel_MedicamentOffert.Visible;
        }

        // recupere ID du medicement selectionné et l'affiche
        private void dataGridView_Medicament_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedicamentClass selectMedic = dataGridView_Medicament.SelectedRows[0].DataBoundItem as MedicamentClass;

            lbl_idMedicSelectionne.Text = selectMedic.Id;
        }

        // recupere ID du medicement offert selectionné et l'affiche
        private void dataGridView_medicOffert_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedicamentOffert selectMedic = dataGridView_medicOffert.SelectedRows[0].DataBoundItem as MedicamentOffert;

            lbl_idMedicOffertSelectionne.Text = selectMedic.Id;
        }

        // ouvre un popUp pour afficher les effets et contre_indication du medicament choisi
        private void btn_description_Click(object sender, EventArgs e)
        {
            if(lbl_idMedicSelectionne.Text != "")
            {
                DescriptionMedicament DM = new DescriptionMedicament(lbl_idMedicSelectionne.Text);
                DM.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez selectioner un medicament (cliquer sur les caracteres pas la case)");
            }
            
        }

        // ouvre popUp pour voir la composition du medicament
        private void btn_compoMedic_Click(object sender, EventArgs e)
        {
            if(lbl_idMedicSelectionne.Text != "")
            {
                CompoMedicament cp = new CompoMedicament(lbl_idMedicSelectionne.Text);
                cp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez selectioner un medicament (cliquer sur les caracteres pas la case)");
            }
        }

        // recupere ID famille et filtre la liste par famille
        private void btn_trierPar_Click(object sender, EventArgs e)
        { 
            try
            {
                Famille idFam = cbx_famille.SelectedItem as Famille;
                dataGridView_Medicament.DataSource = Bdd.ListeFiltrePar(idFam.RecupererId());
            }
            catch(Exception ex)
            {
                if (Erreur.ErreurHttp())
                {
                    this.Close();
                }
            }
        }

        // met la liste à sont etat d'origine
        private void btn_reinitialiserTableau_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_Medicament.DataSource = Bdd.ListeMedicament();
            }
            catch(Exception ex)
            {
                if (Erreur.ErreurHttp())
                {
                    this.Close();
                }
            }
        }

        // supprime un medicament offert et actualise la liste
        private void btn_suppMedicOffert_Click(object sender, EventArgs e)
        {
            try
            {
                if(lbl_idMedicOffertSelectionne.Text != "")
                {
                    Bdd.SuppMedicOffert(lbl_idMedicOffertSelectionne.Text);
                    dataGridView_medicOffert.DataSource = Bdd.ListeMedicamentOffert();
                }
                else
                {
                    MessageBox.Show("Veuillez selectioné un medicament (cliquer sur les caracteres pas sur la case)");
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

        // ouvre une popUp pour modifier les informations du medicament offert
        private void btn_modifierInfoMedicament_Click(object sender, EventArgs e)
        {
            if (lbl_idMedicOffertSelectionne.Text != "")
            {
                modifierInfosMedicOffert infoMedic = new modifierInfosMedicOffert(lbl_idMedicOffertSelectionne.Text);
                infoMedic.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez selectioner un medicament (cliquer sur les caracteres pas la case)");
            }     
        }
        #endregion
    }
}
