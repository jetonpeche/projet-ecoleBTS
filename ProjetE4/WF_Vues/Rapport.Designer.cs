namespace ProjetE4
{
    partial class Rapport
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dateRapport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomPrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bilan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_retour = new System.Windows.Forms.Button();
            this.btn_ajoutRapport = new System.Windows.Forms.Button();
            this.btn_actualiserTableau = new System.Windows.Forms.Button();
            this.txb_rechercheNomPrat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_rechercheDate = new System.Windows.Forms.TextBox();
            this.btn_validerRecherche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateRapport,
            this.NomPrat,
            this.PrenomPrat,
            this.Coef,
            this.NomVisiteur,
            this.PrenomVisiteur,
            this.Motif,
            this.Bilan});
            this.dataGridView.Location = new System.Drawing.Point(12, 153);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1206, 366);
            this.dataGridView.TabIndex = 0;
            // 
            // dateRapport
            // 
            this.dateRapport.HeaderText = "date Rapport";
            this.dateRapport.MinimumWidth = 6;
            this.dateRapport.Name = "dateRapport";
            this.dateRapport.ReadOnly = true;
            this.dateRapport.Visible = false;
            // 
            // NomPrat
            // 
            this.NomPrat.HeaderText = "Nom prat";
            this.NomPrat.MinimumWidth = 6;
            this.NomPrat.Name = "NomPrat";
            this.NomPrat.ReadOnly = true;
            this.NomPrat.Visible = false;
            // 
            // PrenomPrat
            // 
            this.PrenomPrat.HeaderText = "Prenom prat";
            this.PrenomPrat.MinimumWidth = 6;
            this.PrenomPrat.Name = "PrenomPrat";
            this.PrenomPrat.ReadOnly = true;
            this.PrenomPrat.Visible = false;
            // 
            // Coef
            // 
            this.Coef.HeaderText = "Coef";
            this.Coef.MinimumWidth = 6;
            this.Coef.Name = "Coef";
            this.Coef.ReadOnly = true;
            this.Coef.Visible = false;
            // 
            // NomVisiteur
            // 
            this.NomVisiteur.HeaderText = "Nom visiteur";
            this.NomVisiteur.MinimumWidth = 6;
            this.NomVisiteur.Name = "NomVisiteur";
            this.NomVisiteur.ReadOnly = true;
            this.NomVisiteur.Visible = false;
            // 
            // PrenomVisiteur
            // 
            this.PrenomVisiteur.HeaderText = "Prenom visiteur";
            this.PrenomVisiteur.MinimumWidth = 6;
            this.PrenomVisiteur.Name = "PrenomVisiteur";
            this.PrenomVisiteur.ReadOnly = true;
            this.PrenomVisiteur.Visible = false;
            // 
            // Motif
            // 
            this.Motif.HeaderText = "Motif";
            this.Motif.MinimumWidth = 6;
            this.Motif.Name = "Motif";
            this.Motif.ReadOnly = true;
            this.Motif.Visible = false;
            // 
            // Bilan
            // 
            this.Bilan.HeaderText = "Bilan";
            this.Bilan.MinimumWidth = 6;
            this.Bilan.Name = "Bilan";
            this.Bilan.ReadOnly = true;
            this.Bilan.Visible = false;
            // 
            // btn_retour
            // 
            this.btn_retour.BackColor = System.Drawing.Color.Red;
            this.btn_retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retour.ForeColor = System.Drawing.Color.White;
            this.btn_retour.Location = new System.Drawing.Point(438, 107);
            this.btn_retour.Name = "btn_retour";
            this.btn_retour.Size = new System.Drawing.Size(145, 40);
            this.btn_retour.TabIndex = 1;
            this.btn_retour.Text = "Retour accueil";
            this.btn_retour.UseVisualStyleBackColor = false;
            this.btn_retour.Click += new System.EventHandler(this.btn_retour_Click);
            // 
            // btn_ajoutRapport
            // 
            this.btn_ajoutRapport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ajoutRapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutRapport.Location = new System.Drawing.Point(12, 107);
            this.btn_ajoutRapport.Name = "btn_ajoutRapport";
            this.btn_ajoutRapport.Size = new System.Drawing.Size(207, 40);
            this.btn_ajoutRapport.TabIndex = 2;
            this.btn_ajoutRapport.Text = "Ajouter rapport de visite";
            this.btn_ajoutRapport.UseVisualStyleBackColor = false;
            this.btn_ajoutRapport.Click += new System.EventHandler(this.btn_ajoutRapport_Click);
            // 
            // btn_actualiserTableau
            // 
            this.btn_actualiserTableau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_actualiserTableau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualiserTableau.Location = new System.Drawing.Point(225, 107);
            this.btn_actualiserTableau.Name = "btn_actualiserTableau";
            this.btn_actualiserTableau.Size = new System.Drawing.Size(207, 40);
            this.btn_actualiserTableau.TabIndex = 3;
            this.btn_actualiserTableau.Text = "Actualiser tableau";
            this.btn_actualiserTableau.UseVisualStyleBackColor = false;
            this.btn_actualiserTableau.Click += new System.EventHandler(this.btn_actualiserTableau_Click);
            // 
            // txb_rechercheNomPrat
            // 
            this.txb_rechercheNomPrat.Location = new System.Drawing.Point(166, 45);
            this.txb_rechercheNomPrat.Name = "txb_rechercheNomPrat";
            this.txb_rechercheNomPrat.Size = new System.Drawing.Size(266, 22);
            this.txb_rechercheNomPrat.TabIndex = 4;
            this.txb_rechercheNomPrat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Recherche rapport par nom praticien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Recherche rapport par date";
            // 
            // txb_rechercheDate
            // 
            this.txb_rechercheDate.Location = new System.Drawing.Point(679, 45);
            this.txb_rechercheDate.Name = "txb_rechercheDate";
            this.txb_rechercheDate.Size = new System.Drawing.Size(236, 22);
            this.txb_rechercheDate.TabIndex = 7;
            // 
            // btn_validerRecherche
            // 
            this.btn_validerRecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_validerRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validerRecherche.Location = new System.Drawing.Point(921, 39);
            this.btn_validerRecherche.Name = "btn_validerRecherche";
            this.btn_validerRecherche.Size = new System.Drawing.Size(85, 34);
            this.btn_validerRecherche.TabIndex = 8;
            this.btn_validerRecherche.Text = "Valider";
            this.btn_validerRecherche.UseVisualStyleBackColor = false;
            this.btn_validerRecherche.Click += new System.EventHandler(this.btn_validerRecherche_Click);
            // 
            // Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 528);
            this.Controls.Add(this.btn_validerRecherche);
            this.Controls.Add(this.txb_rechercheDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_rechercheNomPrat);
            this.Controls.Add(this.btn_actualiserTableau);
            this.Controls.Add(this.btn_ajoutRapport);
            this.Controls.Add(this.btn_retour);
            this.Controls.Add(this.dataGridView);
            this.Name = "Rapport";
            this.Text = "Rapport";
            this.Load += new System.EventHandler(this.Rapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRapport;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomPrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coef;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bilan;
        private System.Windows.Forms.Button btn_retour;
        private System.Windows.Forms.Button btn_ajoutRapport;
        private System.Windows.Forms.Button btn_actualiserTableau;
        private System.Windows.Forms.TextBox txb_rechercheNomPrat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_rechercheDate;
        private System.Windows.Forms.Button btn_validerRecherche;
    }
}