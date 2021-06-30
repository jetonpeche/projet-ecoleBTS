namespace ProjetE4
{
    partial class modifierInfosMedicOffert
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
            this.txb_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_famille = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_prix = new System.Windows.Forms.TextBox();
            this.txb_qte = new System.Windows.Forms.TextBox();
            this.txb_effets = new System.Windows.Forms.TextBox();
            this.txb_contreIndication = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_modiferInfos = new System.Windows.Forms.Button();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_nom
            // 
            this.txb_nom.Location = new System.Drawing.Point(12, 57);
            this.txb_nom.Name = "txb_nom";
            this.txb_nom.Size = new System.Drawing.Size(211, 22);
            this.txb_nom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom medicament";
            // 
            // cbx_famille
            // 
            this.cbx_famille.FormattingEnabled = true;
            this.cbx_famille.Location = new System.Drawing.Point(229, 55);
            this.cbx_famille.Name = "cbx_famille";
            this.cbx_famille.Size = new System.Drawing.Size(438, 24);
            this.cbx_famille.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Famille medicament";
            // 
            // txb_prix
            // 
            this.txb_prix.Location = new System.Drawing.Point(12, 123);
            this.txb_prix.Name = "txb_prix";
            this.txb_prix.Size = new System.Drawing.Size(260, 22);
            this.txb_prix.TabIndex = 4;
            // 
            // txb_qte
            // 
            this.txb_qte.Location = new System.Drawing.Point(278, 123);
            this.txb_qte.Name = "txb_qte";
            this.txb_qte.Size = new System.Drawing.Size(389, 22);
            this.txb_qte.TabIndex = 5;
            // 
            // txb_effets
            // 
            this.txb_effets.Location = new System.Drawing.Point(12, 186);
            this.txb_effets.Multiline = true;
            this.txb_effets.Name = "txb_effets";
            this.txb_effets.Size = new System.Drawing.Size(655, 71);
            this.txb_effets.TabIndex = 6;
            // 
            // txb_contreIndication
            // 
            this.txb_contreIndication.Location = new System.Drawing.Point(12, 306);
            this.txb_contreIndication.Multiline = true;
            this.txb_contreIndication.Name = "txb_contreIndication";
            this.txb_contreIndication.Size = new System.Drawing.Size(655, 80);
            this.txb_contreIndication.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantité offerte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Effets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contre indication";
            // 
            // btn_modiferInfos
            // 
            this.btn_modiferInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_modiferInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modiferInfos.Location = new System.Drawing.Point(535, 402);
            this.btn_modiferInfos.Name = "btn_modiferInfos";
            this.btn_modiferInfos.Size = new System.Drawing.Size(131, 36);
            this.btn_modiferInfos.TabIndex = 12;
            this.btn_modiferInfos.Text = "Valider modif";
            this.btn_modiferInfos.UseVisualStyleBackColor = false;
            this.btn_modiferInfos.Click += new System.EventHandler(this.btn_modiferInfos_Click);
            // 
            // btn_fermer
            // 
            this.btn_fermer.BackColor = System.Drawing.Color.Red;
            this.btn_fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fermer.ForeColor = System.Drawing.Color.White;
            this.btn_fermer.Location = new System.Drawing.Point(421, 402);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(108, 36);
            this.btn_fermer.TabIndex = 13;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = false;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // modifierInfosMedicOffert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.btn_modiferInfos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_contreIndication);
            this.Controls.Add(this.txb_effets);
            this.Controls.Add(this.txb_qte);
            this.Controls.Add(this.txb_prix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_famille);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_nom);
            this.Name = "modifierInfosMedicOffert";
            this.Text = "modifier medicament";
            this.Load += new System.EventHandler(this.modifierInfosMedicOffert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_famille;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_prix;
        private System.Windows.Forms.TextBox txb_qte;
        private System.Windows.Forms.TextBox txb_effets;
        private System.Windows.Forms.TextBox txb_contreIndication;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_modiferInfos;
        private System.Windows.Forms.Button btn_fermer;
    }
}