namespace ProjetE4
{
    partial class Medicament
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_retourAccueil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_famille = new System.Windows.Forms.ComboBox();
            this.btn_trierPar = new System.Windows.Forms.Button();
            this.btn_changerListe = new System.Windows.Forms.Button();
            this.panel_medicament = new System.Windows.Forms.Panel();
            this.lbl_idMedicSelectionne = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_compoMedic = new System.Windows.Forms.Button();
            this.btn_description = new System.Windows.Forms.Button();
            this.dataGridView_Medicament = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_commercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depotLegal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.famille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_echantillon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_reinitialiserTableau = new System.Windows.Forms.Button();
            this.panel_MedicamentOffert = new System.Windows.Forms.Panel();
            this.lbl_idMedicOffertSelectionne = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btn_suppMedicOffert = new System.Windows.Forms.Button();
            this.btn_modifierInfoMedicament = new System.Windows.Forms.Button();
            this.dataGridView_medicOffert = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.ID_offert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qte_offert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depot_Legal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_medicament.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Medicament)).BeginInit();
            this.panel_MedicamentOffert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_medicOffert)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_retourAccueil
            // 
            this.btn_retourAccueil.BackColor = System.Drawing.Color.Red;
            this.btn_retourAccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retourAccueil.ForeColor = System.Drawing.Color.White;
            this.btn_retourAccueil.Location = new System.Drawing.Point(1094, 12);
            this.btn_retourAccueil.Name = "btn_retourAccueil";
            this.btn_retourAccueil.Size = new System.Drawing.Size(142, 42);
            this.btn_retourAccueil.TabIndex = 0;
            this.btn_retourAccueil.Text = "Retour accueil";
            this.btn_retourAccueil.UseVisualStyleBackColor = false;
            this.btn_retourAccueil.Click += new System.EventHandler(this.btn_retourAccueil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(492, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listing des medicaments";
            // 
            // cbx_famille
            // 
            this.cbx_famille.FormattingEnabled = true;
            this.cbx_famille.Location = new System.Drawing.Point(78, 88);
            this.cbx_famille.Name = "cbx_famille";
            this.cbx_famille.Size = new System.Drawing.Size(448, 24);
            this.cbx_famille.TabIndex = 2;
            // 
            // btn_trierPar
            // 
            this.btn_trierPar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_trierPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trierPar.Location = new System.Drawing.Point(532, 80);
            this.btn_trierPar.Name = "btn_trierPar";
            this.btn_trierPar.Size = new System.Drawing.Size(125, 37);
            this.btn_trierPar.TabIndex = 3;
            this.btn_trierPar.Text = "Valider tri";
            this.btn_trierPar.UseVisualStyleBackColor = false;
            this.btn_trierPar.Click += new System.EventHandler(this.btn_trierPar_Click);
            // 
            // btn_changerListe
            // 
            this.btn_changerListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_changerListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changerListe.Location = new System.Drawing.Point(911, 80);
            this.btn_changerListe.Name = "btn_changerListe";
            this.btn_changerListe.Size = new System.Drawing.Size(325, 37);
            this.btn_changerListe.TabIndex = 4;
            this.btn_changerListe.Text = "Liste medicaments offert ou tous";
            this.btn_changerListe.UseVisualStyleBackColor = false;
            this.btn_changerListe.Click += new System.EventHandler(this.btn_changerListe_Click);
            // 
            // panel_medicament
            // 
            this.panel_medicament.Controls.Add(this.lbl_idMedicSelectionne);
            this.panel_medicament.Controls.Add(this.label3);
            this.panel_medicament.Controls.Add(this.btn_compoMedic);
            this.panel_medicament.Controls.Add(this.btn_description);
            this.panel_medicament.Controls.Add(this.dataGridView_Medicament);
            this.panel_medicament.Controls.Add(this.label2);
            this.panel_medicament.Location = new System.Drawing.Point(0, 155);
            this.panel_medicament.Name = "panel_medicament";
            this.panel_medicament.Size = new System.Drawing.Size(1347, 433);
            this.panel_medicament.TabIndex = 5;
            // 
            // lbl_idMedicSelectionne
            // 
            this.lbl_idMedicSelectionne.AutoSize = true;
            this.lbl_idMedicSelectionne.Location = new System.Drawing.Point(257, 70);
            this.lbl_idMedicSelectionne.Name = "lbl_idMedicSelectionne";
            this.lbl_idMedicSelectionne.Size = new System.Drawing.Size(0, 17);
            this.lbl_idMedicSelectionne.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID du medicament selectionné:";
            // 
            // btn_compoMedic
            // 
            this.btn_compoMedic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_compoMedic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compoMedic.Location = new System.Drawing.Point(162, 109);
            this.btn_compoMedic.Name = "btn_compoMedic";
            this.btn_compoMedic.Size = new System.Drawing.Size(256, 43);
            this.btn_compoMedic.TabIndex = 7;
            this.btn_compoMedic.Text = "Voir composition Medicament";
            this.btn_compoMedic.UseVisualStyleBackColor = false;
            this.btn_compoMedic.Click += new System.EventHandler(this.btn_compoMedic_Click);
            // 
            // btn_description
            // 
            this.btn_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_description.Location = new System.Drawing.Point(8, 109);
            this.btn_description.Name = "btn_description";
            this.btn_description.Size = new System.Drawing.Size(148, 43);
            this.btn_description.TabIndex = 6;
            this.btn_description.Text = "Voir Description";
            this.btn_description.UseVisualStyleBackColor = false;
            this.btn_description.Click += new System.EventHandler(this.btn_description_Click);
            // 
            // dataGridView_Medicament
            // 
            this.dataGridView_Medicament.AllowUserToDeleteRows = false;
            this.dataGridView_Medicament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Medicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Medicament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nom_commercial,
            this.depotLegal,
            this.famille,
            this.prix_echantillon});
            this.dataGridView_Medicament.Location = new System.Drawing.Point(0, 158);
            this.dataGridView_Medicament.Name = "dataGridView_Medicament";
            this.dataGridView_Medicament.ReadOnly = true;
            this.dataGridView_Medicament.RowHeadersWidth = 51;
            this.dataGridView_Medicament.RowTemplate.Height = 24;
            this.dataGridView_Medicament.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Medicament.Size = new System.Drawing.Size(1347, 275);
            this.dataGridView_Medicament.TabIndex = 1;
            this.dataGridView_Medicament.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Medicament_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // nom_commercial
            // 
            this.nom_commercial.HeaderText = "nom commercial";
            this.nom_commercial.MinimumWidth = 6;
            this.nom_commercial.Name = "nom_commercial";
            this.nom_commercial.ReadOnly = true;
            this.nom_commercial.Visible = false;
            // 
            // depotLegal
            // 
            this.depotLegal.HeaderText = "depot legal";
            this.depotLegal.MinimumWidth = 6;
            this.depotLegal.Name = "depotLegal";
            this.depotLegal.ReadOnly = true;
            this.depotLegal.Visible = false;
            // 
            // famille
            // 
            this.famille.HeaderText = "famille";
            this.famille.MinimumWidth = 6;
            this.famille.Name = "famille";
            this.famille.ReadOnly = true;
            this.famille.Visible = false;
            // 
            // prix_echantillon
            // 
            this.prix_echantillon.HeaderText = "prix echantillon";
            this.prix_echantillon.MinimumWidth = 6;
            this.prix_echantillon.Name = "prix_echantillon";
            this.prix_echantillon.ReadOnly = true;
            this.prix_echantillon.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Medicaments";
            // 
            // btn_reinitialiserTableau
            // 
            this.btn_reinitialiserTableau.BackColor = System.Drawing.Color.Yellow;
            this.btn_reinitialiserTableau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reinitialiserTableau.Location = new System.Drawing.Point(693, 80);
            this.btn_reinitialiserTableau.Name = "btn_reinitialiserTableau";
            this.btn_reinitialiserTableau.Size = new System.Drawing.Size(149, 37);
            this.btn_reinitialiserTableau.TabIndex = 6;
            this.btn_reinitialiserTableau.Text = "Remise à zero";
            this.btn_reinitialiserTableau.UseVisualStyleBackColor = false;
            this.btn_reinitialiserTableau.Click += new System.EventHandler(this.btn_reinitialiserTableau_Click);
            // 
            // panel_MedicamentOffert
            // 
            this.panel_MedicamentOffert.Controls.Add(this.lbl_idMedicOffertSelectionne);
            this.panel_MedicamentOffert.Controls.Add(this.label);
            this.panel_MedicamentOffert.Controls.Add(this.btn_suppMedicOffert);
            this.panel_MedicamentOffert.Controls.Add(this.btn_modifierInfoMedicament);
            this.panel_MedicamentOffert.Controls.Add(this.dataGridView_medicOffert);
            this.panel_MedicamentOffert.Controls.Add(this.label6);
            this.panel_MedicamentOffert.Location = new System.Drawing.Point(0, 152);
            this.panel_MedicamentOffert.Name = "panel_MedicamentOffert";
            this.panel_MedicamentOffert.Size = new System.Drawing.Size(1347, 433);
            this.panel_MedicamentOffert.TabIndex = 11;
            // 
            // lbl_idMedicOffertSelectionne
            // 
            this.lbl_idMedicOffertSelectionne.AutoSize = true;
            this.lbl_idMedicOffertSelectionne.Location = new System.Drawing.Point(273, 71);
            this.lbl_idMedicOffertSelectionne.Name = "lbl_idMedicOffertSelectionne";
            this.lbl_idMedicOffertSelectionne.Size = new System.Drawing.Size(0, 17);
            this.lbl_idMedicOffertSelectionne.TabIndex = 10;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Red;
            this.label.Location = new System.Drawing.Point(12, 70);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(239, 18);
            this.label.TabIndex = 9;
            this.label.Text = "ID du medicament selectionné:";
            // 
            // btn_suppMedicOffert
            // 
            this.btn_suppMedicOffert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_suppMedicOffert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppMedicOffert.Location = new System.Drawing.Point(162, 109);
            this.btn_suppMedicOffert.Name = "btn_suppMedicOffert";
            this.btn_suppMedicOffert.Size = new System.Drawing.Size(256, 43);
            this.btn_suppMedicOffert.TabIndex = 7;
            this.btn_suppMedicOffert.Text = "Supprimer Midicament Offert";
            this.btn_suppMedicOffert.UseVisualStyleBackColor = false;
            this.btn_suppMedicOffert.Click += new System.EventHandler(this.btn_suppMedicOffert_Click);
            // 
            // btn_modifierInfoMedicament
            // 
            this.btn_modifierInfoMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_modifierInfoMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifierInfoMedicament.Location = new System.Drawing.Point(8, 109);
            this.btn_modifierInfoMedicament.Name = "btn_modifierInfoMedicament";
            this.btn_modifierInfoMedicament.Size = new System.Drawing.Size(148, 43);
            this.btn_modifierInfoMedicament.TabIndex = 6;
            this.btn_modifierInfoMedicament.Text = "Modifier";
            this.btn_modifierInfoMedicament.UseVisualStyleBackColor = false;
            this.btn_modifierInfoMedicament.Click += new System.EventHandler(this.btn_modifierInfoMedicament_Click);
            // 
            // dataGridView_medicOffert
            // 
            this.dataGridView_medicOffert.AllowUserToDeleteRows = false;
            this.dataGridView_medicOffert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_medicOffert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_medicOffert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.ID_offert,
            this.nomCom,
            this.qte_offert,
            this.depot_Legal});
            this.dataGridView_medicOffert.Location = new System.Drawing.Point(0, 158);
            this.dataGridView_medicOffert.Name = "dataGridView_medicOffert";
            this.dataGridView_medicOffert.ReadOnly = true;
            this.dataGridView_medicOffert.RowHeadersWidth = 51;
            this.dataGridView_medicOffert.RowTemplate.Height = 24;
            this.dataGridView_medicOffert.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_medicOffert.Size = new System.Drawing.Size(1347, 275);
            this.dataGridView_medicOffert.TabIndex = 1;
            this.dataGridView_medicOffert.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_medicOffert_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "nom commercial";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "depot legal";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "famille";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "prix echantillon";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Medicaments offerts";
            // 
            // ID_offert
            // 
            this.ID_offert.HeaderText = "ID";
            this.ID_offert.MinimumWidth = 6;
            this.ID_offert.Name = "ID_offert";
            this.ID_offert.ReadOnly = true;
            this.ID_offert.Visible = false;
            // 
            // nomCom
            // 
            this.nomCom.HeaderText = "nom";
            this.nomCom.MinimumWidth = 6;
            this.nomCom.Name = "nomCom";
            this.nomCom.ReadOnly = true;
            this.nomCom.Visible = false;
            // 
            // qte_offert
            // 
            this.qte_offert.HeaderText = "Quantité offerte";
            this.qte_offert.MinimumWidth = 6;
            this.qte_offert.Name = "qte_offert";
            this.qte_offert.ReadOnly = true;
            this.qte_offert.Visible = false;
            // 
            // depot_Legal
            // 
            this.depot_Legal.HeaderText = "depot legal";
            this.depot_Legal.MinimumWidth = 6;
            this.depot_Legal.Name = "depot_Legal";
            this.depot_Legal.ReadOnly = true;
            this.depot_Legal.Visible = false;
            // 
            // Medicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 589);
            this.Controls.Add(this.panel_MedicamentOffert);
            this.Controls.Add(this.btn_reinitialiserTableau);
            this.Controls.Add(this.panel_medicament);
            this.Controls.Add(this.btn_changerListe);
            this.Controls.Add(this.btn_trierPar);
            this.Controls.Add(this.cbx_famille);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_retourAccueil);
            this.Name = "Medicament";
            this.Text = "Medicament";
            this.Load += new System.EventHandler(this.Medicament_Load);
            this.panel_medicament.ResumeLayout(false);
            this.panel_medicament.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Medicament)).EndInit();
            this.panel_MedicamentOffert.ResumeLayout(false);
            this.panel_MedicamentOffert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_medicOffert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_retourAccueil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_famille;
        private System.Windows.Forms.Button btn_trierPar;
        private System.Windows.Forms.Button btn_changerListe;
        private System.Windows.Forms.Panel panel_medicament;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Medicament;
        private System.Windows.Forms.Button btn_description;
        private System.Windows.Forms.Button btn_compoMedic;
        private System.Windows.Forms.Label lbl_idMedicSelectionne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_commercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn depotLegal;
        private System.Windows.Forms.DataGridViewTextBoxColumn famille;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_echantillon;
        private System.Windows.Forms.Button btn_reinitialiserTableau;
        private System.Windows.Forms.Panel panel_MedicamentOffert;
        private System.Windows.Forms.Label lbl_idMedicOffertSelectionne;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_suppMedicOffert;
        private System.Windows.Forms.Button btn_modifierInfoMedicament;
        private System.Windows.Forms.DataGridView dataGridView_medicOffert;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_offert;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn qte_offert;
        private System.Windows.Forms.DataGridViewTextBoxColumn depot_Legal;
    }
}