namespace ProjetE4
{
    partial class Accueil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblk_medicament = new System.Windows.Forms.LinkLabel();
            this.lblk_rapport = new System.Windows.Forms.LinkLabel();
            this.btn_deconnexion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomComposant = new System.Windows.Forms.TextBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.lblk_medicament);
            this.panel1.Controls.Add(this.lblk_rapport);
            this.panel1.Controls.Add(this.btn_deconnexion);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 73);
            this.panel1.TabIndex = 0;
            // 
            // lblk_medicament
            // 
            this.lblk_medicament.AutoSize = true;
            this.lblk_medicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblk_medicament.LinkColor = System.Drawing.Color.White;
            this.lblk_medicament.Location = new System.Drawing.Point(234, 22);
            this.lblk_medicament.Name = "lblk_medicament";
            this.lblk_medicament.Size = new System.Drawing.Size(197, 25);
            this.lblk_medicament.TabIndex = 2;
            this.lblk_medicament.TabStop = true;
            this.lblk_medicament.Text = "Listing medicament";
            this.lblk_medicament.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblk_medicament_LinkClicked);
            // 
            // lblk_rapport
            // 
            this.lblk_rapport.AutoSize = true;
            this.lblk_rapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblk_rapport.LinkColor = System.Drawing.Color.White;
            this.lblk_rapport.Location = new System.Drawing.Point(24, 22);
            this.lblk_rapport.Name = "lblk_rapport";
            this.lblk_rapport.Size = new System.Drawing.Size(173, 25);
            this.lblk_rapport.TabIndex = 1;
            this.lblk_rapport.TabStop = true;
            this.lblk_rapport.Text = "Rapport de visite";
            this.lblk_rapport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblk_rapport_LinkClicked);
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.BackColor = System.Drawing.Color.Red;
            this.btn_deconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deconnexion.ForeColor = System.Drawing.Color.White;
            this.btn_deconnexion.Location = new System.Drawing.Point(463, 13);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(132, 50);
            this.btn_deconnexion.TabIndex = 0;
            this.btn_deconnexion.Text = "Deconnexion";
            this.btn_deconnexion.UseVisualStyleBackColor = false;
            this.btn_deconnexion.Click += new System.EventHandler(this.btn_deconnexion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajout d\'un composant dans la base de donnée";
            // 
            // tb_nomComposant
            // 
            this.tb_nomComposant.Location = new System.Drawing.Point(218, 209);
            this.tb_nomComposant.Name = "tb_nomComposant";
            this.tb_nomComposant.Size = new System.Drawing.Size(168, 22);
            this.tb_nomComposant.TabIndex = 2;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.ForeColor = System.Drawing.Color.Black;
            this.btn_ajouter.Location = new System.Drawing.Point(239, 258);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(120, 48);
            this.btn_ajouter.TabIndex = 3;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.tb_nomComposant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblk_medicament;
        private System.Windows.Forms.LinkLabel lblk_rapport;
        private System.Windows.Forms.Button btn_deconnexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomComposant;
        private System.Windows.Forms.Button btn_ajouter;
    }
}