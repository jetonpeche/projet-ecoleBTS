namespace ProjetE4
{
    partial class AjouterRapport
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
            this.cbx_praticien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ValiderRapport = new System.Windows.Forms.Button();
            this.cbx_visiteur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_motif = new System.Windows.Forms.TextBox();
            this.txb_bilan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_praticien
            // 
            this.cbx_praticien.FormattingEnabled = true;
            this.cbx_praticien.Location = new System.Drawing.Point(12, 56);
            this.cbx_praticien.Name = "cbx_praticien";
            this.cbx_praticien.Size = new System.Drawing.Size(262, 24);
            this.cbx_praticien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste praticien";
            // 
            // btn_ValiderRapport
            // 
            this.btn_ValiderRapport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ValiderRapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ValiderRapport.Location = new System.Drawing.Point(397, 380);
            this.btn_ValiderRapport.Name = "btn_ValiderRapport";
            this.btn_ValiderRapport.Size = new System.Drawing.Size(137, 44);
            this.btn_ValiderRapport.TabIndex = 2;
            this.btn_ValiderRapport.Text = "Valider rapport";
            this.btn_ValiderRapport.UseVisualStyleBackColor = false;
            this.btn_ValiderRapport.Click += new System.EventHandler(this.btn_ValiderPraticien_Click);
            // 
            // cbx_visiteur
            // 
            this.cbx_visiteur.FormattingEnabled = true;
            this.cbx_visiteur.Location = new System.Drawing.Point(307, 56);
            this.cbx_visiteur.Name = "cbx_visiteur";
            this.cbx_visiteur.Size = new System.Drawing.Size(233, 24);
            this.cbx_visiteur.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liste des visiteurs";
            // 
            // txb_motif
            // 
            this.txb_motif.Location = new System.Drawing.Point(12, 130);
            this.txb_motif.Multiline = true;
            this.txb_motif.Name = "txb_motif";
            this.txb_motif.Size = new System.Drawing.Size(522, 50);
            this.txb_motif.TabIndex = 5;
            // 
            // txb_bilan
            // 
            this.txb_bilan.Location = new System.Drawing.Point(12, 215);
            this.txb_bilan.Multiline = true;
            this.txb_bilan.Name = "txb_bilan";
            this.txb_bilan.Size = new System.Drawing.Size(522, 144);
            this.txb_bilan.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Motif";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bilan";
            // 
            // btn_fermer
            // 
            this.btn_fermer.BackColor = System.Drawing.Color.Red;
            this.btn_fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fermer.ForeColor = System.Drawing.Color.White;
            this.btn_fermer.Location = new System.Drawing.Point(266, 380);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(104, 44);
            this.btn_fermer.TabIndex = 9;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = false;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // AjouterRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_bilan);
            this.Controls.Add(this.txb_motif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_visiteur);
            this.Controls.Add(this.btn_ValiderRapport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_praticien);
            this.Name = "AjouterRapport";
            this.Text = "AjouterRapport";
            this.Load += new System.EventHandler(this.AjouterRapport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_praticien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ValiderRapport;
        private System.Windows.Forms.ComboBox cbx_visiteur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_motif;
        private System.Windows.Forms.TextBox txb_bilan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_fermer;
    }
}