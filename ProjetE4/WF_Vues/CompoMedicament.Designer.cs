namespace ProjetE4
{
    partial class CompoMedicament
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
            this.dataGridView_compoMedic = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Composant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_composant = new System.Windows.Forms.ComboBox();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.lbl_composerSelectionne = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_compoMedic)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_compoMedic
            // 
            this.dataGridView_compoMedic.AllowUserToDeleteRows = false;
            this.dataGridView_compoMedic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_compoMedic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_compoMedic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Composant});
            this.dataGridView_compoMedic.Location = new System.Drawing.Point(12, 196);
            this.dataGridView_compoMedic.Name = "dataGridView_compoMedic";
            this.dataGridView_compoMedic.ReadOnly = true;
            this.dataGridView_compoMedic.RowHeadersWidth = 51;
            this.dataGridView_compoMedic.RowTemplate.Height = 24;
            this.dataGridView_compoMedic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_compoMedic.Size = new System.Drawing.Size(776, 197);
            this.dataGridView_compoMedic.TabIndex = 0;
            this.dataGridView_compoMedic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_compoMedic_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Composant
            // 
            this.Composant.HeaderText = "Composant";
            this.Composant.MinimumWidth = 6;
            this.Composant.Name = "Composant";
            this.Composant.ReadOnly = true;
            this.Composant.Visible = false;
            // 
            // cbx_composant
            // 
            this.cbx_composant.FormattingEnabled = true;
            this.cbx_composant.Location = new System.Drawing.Point(579, 12);
            this.cbx_composant.Name = "cbx_composant";
            this.cbx_composant.Size = new System.Drawing.Size(209, 24);
            this.cbx_composant.TabIndex = 1;
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.Yellow;
            this.btn_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.Location = new System.Drawing.Point(579, 56);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(100, 41);
            this.btn_modifier.TabIndex = 2;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.Red;
            this.btn_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer.Location = new System.Drawing.Point(688, 56);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(100, 41);
            this.btn_supprimer.TabIndex = 3;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Composer du medicament selectionné:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(13, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Liste des composants du medicament";
            // 
            // btn_fermer
            // 
            this.btn_fermer.BackColor = System.Drawing.Color.Red;
            this.btn_fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fermer.ForeColor = System.Drawing.Color.White;
            this.btn_fermer.Location = new System.Drawing.Point(688, 399);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(100, 39);
            this.btn_fermer.TabIndex = 6;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = false;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // lbl_composerSelectionne
            // 
            this.lbl_composerSelectionne.AutoSize = true;
            this.lbl_composerSelectionne.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_composerSelectionne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_composerSelectionne.Location = new System.Drawing.Point(13, 41);
            this.lbl_composerSelectionne.Name = "lbl_composerSelectionne";
            this.lbl_composerSelectionne.Size = new System.Drawing.Size(0, 17);
            this.lbl_composerSelectionne.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modifier par";
            // 
            // CompoMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_composerSelectionne);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.cbx_composant);
            this.Controls.Add(this.dataGridView_compoMedic);
            this.Name = "CompoMedicament";
            this.Text = "CompoMedicament";
            this.Load += new System.EventHandler(this.CompoMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_compoMedic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_compoMedic;
        private System.Windows.Forms.ComboBox cbx_composant;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Label lbl_composerSelectionne;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Composant;
        private System.Windows.Forms.Label label3;
    }
}