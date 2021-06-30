namespace ProjetE4
{
    partial class DescriptionMedicament
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
            this.txb_effets = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_contreIndication = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_effets
            // 
            this.txb_effets.Location = new System.Drawing.Point(12, 81);
            this.txb_effets.Multiline = true;
            this.txb_effets.Name = "txb_effets";
            this.txb_effets.ReadOnly = true;
            this.txb_effets.Size = new System.Drawing.Size(555, 112);
            this.txb_effets.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Effets";
            // 
            // txb_contreIndication
            // 
            this.txb_contreIndication.Location = new System.Drawing.Point(12, 258);
            this.txb_contreIndication.Multiline = true;
            this.txb_contreIndication.Name = "txb_contreIndication";
            this.txb_contreIndication.ReadOnly = true;
            this.txb_contreIndication.Size = new System.Drawing.Size(555, 119);
            this.txb_contreIndication.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contre indication";
            // 
            // btn_fermer
            // 
            this.btn_fermer.BackColor = System.Drawing.Color.Red;
            this.btn_fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fermer.ForeColor = System.Drawing.Color.White;
            this.btn_fermer.Location = new System.Drawing.Point(447, 393);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(120, 45);
            this.btn_fermer.TabIndex = 4;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = false;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // DescriptionMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_contreIndication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_effets);
            this.Name = "DescriptionMedicament";
            this.Text = "Description Medicament";
            this.Load += new System.EventHandler(this.DescriptionMedicament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_effets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_contreIndication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_fermer;
    }
}