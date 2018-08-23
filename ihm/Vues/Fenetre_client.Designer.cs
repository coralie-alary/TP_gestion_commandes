namespace ihm.Vues
{
    partial class Fenetre_client
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
            this.btnFermer = new System.Windows.Forms.Button();
            this.grpClients = new System.Windows.Forms.GroupBox();
            this.grpProfessionnelC = new System.Windows.Forms.GroupBox();
            this.datCreationC = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtNClients = new System.Windows.Forms.TextBox();
            this.comboClients = new System.Windows.Forms.ComboBox();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.labIdentifiant = new System.Windows.Forms.Label();
            this.labNom = new System.Windows.Forms.Label();
            this.labNClients = new System.Windows.Forms.Label();
            this.labClients = new System.Windows.Forms.Label();
            this.grpCategorie = new System.Windows.Forms.GroupBox();
            this.radProfessionnel = new System.Windows.Forms.RadioButton();
            this.radParticulier = new System.Windows.Forms.RadioButton();
            this.grpClients.SuspendLayout();
            this.grpProfessionnelC.SuspendLayout();
            this.grpCategorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.CadetBlue;
            this.btnFermer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.Black;
            this.btnFermer.Location = new System.Drawing.Point(196, 409);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 31);
            this.btnFermer.TabIndex = 17;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            // 
            // grpClients
            // 
            this.grpClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.grpClients.Controls.Add(this.grpProfessionnelC);
            this.grpClients.Controls.Add(this.btnEffacer);
            this.grpClients.Controls.Add(this.btnModifier);
            this.grpClients.Controls.Add(this.btnAjouter);
            this.grpClients.Controls.Add(this.txtNClients);
            this.grpClients.Controls.Add(this.comboClients);
            this.grpClients.Controls.Add(this.txtIdentifiant);
            this.grpClients.Controls.Add(this.txtNom);
            this.grpClients.Controls.Add(this.labIdentifiant);
            this.grpClients.Controls.Add(this.labNom);
            this.grpClients.Controls.Add(this.labNClients);
            this.grpClients.Controls.Add(this.labClients);
            this.grpClients.Controls.Add(this.grpCategorie);
            this.grpClients.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.grpClients.ForeColor = System.Drawing.Color.Salmon;
            this.grpClients.Location = new System.Drawing.Point(12, 12);
            this.grpClients.Name = "grpClients";
            this.grpClients.Size = new System.Drawing.Size(445, 386);
            this.grpClients.TabIndex = 16;
            this.grpClients.TabStop = false;
            this.grpClients.Text = "Gestion Clients";
            // 
            // grpProfessionnelC
            // 
            this.grpProfessionnelC.Controls.Add(this.datCreationC);
            this.grpProfessionnelC.Controls.Add(this.label1);
            this.grpProfessionnelC.ForeColor = System.Drawing.Color.Salmon;
            this.grpProfessionnelC.Location = new System.Drawing.Point(7, 270);
            this.grpProfessionnelC.Name = "grpProfessionnelC";
            this.grpProfessionnelC.Size = new System.Drawing.Size(432, 55);
            this.grpProfessionnelC.TabIndex = 18;
            this.grpProfessionnelC.TabStop = false;
            this.grpProfessionnelC.Text = "Professionnel";
            // 
            // datCreationC
            // 
            this.datCreationC.Location = new System.Drawing.Point(159, 18);
            this.datCreationC.Name = "datCreationC";
            this.datCreationC.Size = new System.Drawing.Size(267, 31);
            this.datCreationC.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Date de création";
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEffacer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffacer.ForeColor = System.Drawing.Color.Black;
            this.btnEffacer.Location = new System.Drawing.Point(348, 345);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(75, 31);
            this.btnEffacer.TabIndex = 17;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnModifier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.Black;
            this.btnModifier.Location = new System.Drawing.Point(184, 345);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 31);
            this.btnModifier.TabIndex = 16;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAjouter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Black;
            this.btnAjouter.Location = new System.Drawing.Point(20, 345);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 31);
            this.btnAjouter.TabIndex = 15;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            // 
            // txtNClients
            // 
            this.txtNClients.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNClients.Location = new System.Drawing.Point(349, 63);
            this.txtNClients.Name = "txtNClients";
            this.txtNClients.Size = new System.Drawing.Size(73, 19);
            this.txtNClients.TabIndex = 8;
            this.txtNClients.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboClients
            // 
            this.comboClients.BackColor = System.Drawing.Color.Bisque;
            this.comboClients.FormattingEnabled = true;
            this.comboClients.Location = new System.Drawing.Point(14, 58);
            this.comboClients.Name = "comboClients";
            this.comboClients.Size = new System.Drawing.Size(222, 31);
            this.comboClients.TabIndex = 7;
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.BackColor = System.Drawing.Color.Bisque;
            this.txtIdentifiant.Location = new System.Drawing.Point(130, 169);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(240, 31);
            this.txtIdentifiant.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.Bisque;
            this.txtNom.Location = new System.Drawing.Point(130, 131);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(240, 31);
            this.txtNom.TabIndex = 5;
            // 
            // labIdentifiant
            // 
            this.labIdentifiant.AutoSize = true;
            this.labIdentifiant.ForeColor = System.Drawing.Color.Bisque;
            this.labIdentifiant.Location = new System.Drawing.Point(15, 177);
            this.labIdentifiant.Name = "labIdentifiant";
            this.labIdentifiant.Size = new System.Drawing.Size(94, 23);
            this.labIdentifiant.TabIndex = 4;
            this.labIdentifiant.Text = "Identifiant";
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.ForeColor = System.Drawing.Color.Bisque;
            this.labNom.Location = new System.Drawing.Point(15, 139);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(50, 23);
            this.labNom.TabIndex = 3;
            this.labNom.Text = "Nom";
            // 
            // labNClients
            // 
            this.labNClients.AutoSize = true;
            this.labNClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labNClients.ForeColor = System.Drawing.Color.Bisque;
            this.labNClients.Location = new System.Drawing.Point(260, 66);
            this.labNClients.Name = "labNClients";
            this.labNClients.Size = new System.Drawing.Size(61, 16);
            this.labNClients.TabIndex = 2;
            this.labNClients.Text = "N Clients";
            // 
            // labClients
            // 
            this.labClients.AutoSize = true;
            this.labClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labClients.ForeColor = System.Drawing.Color.Bisque;
            this.labClients.Location = new System.Drawing.Point(15, 34);
            this.labClients.Name = "labClients";
            this.labClients.Size = new System.Drawing.Size(71, 16);
            this.labClients.TabIndex = 1;
            this.labClients.Text = "Les clients";
            // 
            // grpCategorie
            // 
            this.grpCategorie.Controls.Add(this.radProfessionnel);
            this.grpCategorie.Controls.Add(this.radParticulier);
            this.grpCategorie.ForeColor = System.Drawing.Color.Salmon;
            this.grpCategorie.Location = new System.Drawing.Point(7, 216);
            this.grpCategorie.Name = "grpCategorie";
            this.grpCategorie.Size = new System.Drawing.Size(432, 55);
            this.grpCategorie.TabIndex = 0;
            this.grpCategorie.TabStop = false;
            this.grpCategorie.Text = "Categorie";
            // 
            // radProfessionnel
            // 
            this.radProfessionnel.AutoSize = true;
            this.radProfessionnel.Font = new System.Drawing.Font("Arial", 12F);
            this.radProfessionnel.ForeColor = System.Drawing.Color.DarkOrange;
            this.radProfessionnel.Location = new System.Drawing.Point(295, 26);
            this.radProfessionnel.Name = "radProfessionnel";
            this.radProfessionnel.Size = new System.Drawing.Size(121, 22);
            this.radProfessionnel.TabIndex = 1;
            this.radProfessionnel.TabStop = true;
            this.radProfessionnel.Text = "Professionnel";
            this.radProfessionnel.UseVisualStyleBackColor = true;
            // 
            // radParticulier
            // 
            this.radParticulier.AutoSize = true;
            this.radParticulier.Font = new System.Drawing.Font("Arial", 12F);
            this.radParticulier.ForeColor = System.Drawing.Color.DarkOrange;
            this.radParticulier.Location = new System.Drawing.Point(11, 26);
            this.radParticulier.Name = "radParticulier";
            this.radParticulier.Size = new System.Drawing.Size(96, 22);
            this.radParticulier.TabIndex = 0;
            this.radParticulier.TabStop = true;
            this.radParticulier.Text = "Particulier";
            this.radParticulier.UseVisualStyleBackColor = true;
            // 
            // Fenetre_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.grpClients);
            this.Name = "Fenetre_client";
            this.Text = "Fenetre_client";
            this.grpClients.ResumeLayout(false);
            this.grpClients.PerformLayout();
            this.grpProfessionnelC.ResumeLayout(false);
            this.grpProfessionnelC.PerformLayout();
            this.grpCategorie.ResumeLayout(false);
            this.grpCategorie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.GroupBox grpClients;
        private System.Windows.Forms.GroupBox grpProfessionnelC;
        public System.Windows.Forms.DateTimePicker datCreationC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtNClients;
        private System.Windows.Forms.ComboBox comboClients;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label labIdentifiant;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.Label labNClients;
        private System.Windows.Forms.Label labClients;
        private System.Windows.Forms.GroupBox grpCategorie;
        private System.Windows.Forms.RadioButton radProfessionnel;
        private System.Windows.Forms.RadioButton radParticulier;
    }
}