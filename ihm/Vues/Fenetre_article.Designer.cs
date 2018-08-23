namespace IHM.Vues
{
    partial class Fenetre_article
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
            this.txtPrixHTA = new System.Windows.Forms.TextBox();
            this.txtEditeurA = new System.Windows.Forms.TextBox();
            this.labPrixHTA = new System.Windows.Forms.Label();
            this.labEditeurA = new System.Windows.Forms.Label();
            this.labReferencedansA = new System.Windows.Forms.Label();
            this.grpCategorieA = new System.Windows.Forms.GroupBox();
            this.radOuvrageA = new System.Windows.Forms.RadioButton();
            this.radDvdA = new System.Windows.Forms.RadioButton();
            this.txtNReferenceA = new System.Windows.Forms.TextBox();
            this.txtReferenceA = new System.Windows.Forms.TextBox();
            this.txtNomA = new System.Windows.Forms.TextBox();
            this.labReferenceA = new System.Windows.Forms.Label();
            this.labNomA = new System.Windows.Forms.Label();
            this.labNCatalogueA = new System.Windows.Forms.Label();
            this.grpDvdA = new System.Windows.Forms.GroupBox();
            this.txtDureeA = new System.Windows.Forms.TextBox();
            this.labDureeA = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grpClients.SuspendLayout();
            this.grpCategorieA.SuspendLayout();
            this.grpDvdA.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.CadetBlue;
            this.btnFermer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.Black;
            this.btnFermer.Location = new System.Drawing.Point(196, 435);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 31);
            this.btnFermer.TabIndex = 17;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            // 
            // grpClients
            // 
            this.grpClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.grpClients.Controls.Add(this.checkBox1);
            this.grpClients.Controls.Add(this.grpDvdA);
            this.grpClients.Controls.Add(this.labNCatalogueA);
            this.grpClients.Controls.Add(this.txtReferenceA);
            this.grpClients.Controls.Add(this.txtNomA);
            this.grpClients.Controls.Add(this.txtNReferenceA);
            this.grpClients.Controls.Add(this.labReferenceA);
            this.grpClients.Controls.Add(this.labReferencedansA);
            this.grpClients.Controls.Add(this.labNomA);
            this.grpClients.Controls.Add(this.txtPrixHTA);
            this.grpClients.Controls.Add(this.txtEditeurA);
            this.grpClients.Controls.Add(this.labPrixHTA);
            this.grpClients.Controls.Add(this.labEditeurA);
            this.grpClients.Controls.Add(this.grpCategorieA);
            this.grpClients.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.grpClients.ForeColor = System.Drawing.Color.Salmon;
            this.grpClients.Location = new System.Drawing.Point(12, 12);
            this.grpClients.Name = "grpClients";
            this.grpClients.Size = new System.Drawing.Size(445, 417);
            this.grpClients.TabIndex = 16;
            this.grpClients.TabStop = false;
            this.grpClients.Text = "Informations article";
            // 
            // txtPrixHTA
            // 
            this.txtPrixHTA.BackColor = System.Drawing.Color.Bisque;
            this.txtPrixHTA.Location = new System.Drawing.Point(142, 142);
            this.txtPrixHTA.Name = "txtPrixHTA";
            this.txtPrixHTA.Size = new System.Drawing.Size(281, 31);
            this.txtPrixHTA.TabIndex = 6;
            // 
            // txtEditeurA
            // 
            this.txtEditeurA.BackColor = System.Drawing.Color.Bisque;
            this.txtEditeurA.Location = new System.Drawing.Point(142, 104);
            this.txtEditeurA.Name = "txtEditeurA";
            this.txtEditeurA.Size = new System.Drawing.Size(281, 31);
            this.txtEditeurA.TabIndex = 5;
            // 
            // labPrixHTA
            // 
            this.labPrixHTA.AutoSize = true;
            this.labPrixHTA.ForeColor = System.Drawing.Color.Bisque;
            this.labPrixHTA.Location = new System.Drawing.Point(27, 150);
            this.labPrixHTA.Name = "labPrixHTA";
            this.labPrixHTA.Size = new System.Drawing.Size(69, 23);
            this.labPrixHTA.TabIndex = 4;
            this.labPrixHTA.Text = "Prix HT";
            // 
            // labEditeurA
            // 
            this.labEditeurA.AutoSize = true;
            this.labEditeurA.ForeColor = System.Drawing.Color.Bisque;
            this.labEditeurA.Location = new System.Drawing.Point(27, 112);
            this.labEditeurA.Name = "labEditeurA";
            this.labEditeurA.Size = new System.Drawing.Size(69, 23);
            this.labEditeurA.TabIndex = 3;
            this.labEditeurA.Text = "Editeur";
            // 
            // labReferencedansA
            // 
            this.labReferencedansA.AutoSize = true;
            this.labReferencedansA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labReferencedansA.ForeColor = System.Drawing.Color.Bisque;
            this.labReferencedansA.Location = new System.Drawing.Point(155, 337);
            this.labReferencedansA.Name = "labReferencedansA";
            this.labReferencedansA.Size = new System.Drawing.Size(104, 16);
            this.labReferencedansA.TabIndex = 2;
            this.labReferencedansA.Text = "Réferencé dans";
            // 
            // grpCategorieA
            // 
            this.grpCategorieA.Controls.Add(this.radOuvrageA);
            this.grpCategorieA.Controls.Add(this.radDvdA);
            this.grpCategorieA.ForeColor = System.Drawing.Color.Salmon;
            this.grpCategorieA.Location = new System.Drawing.Point(7, 216);
            this.grpCategorieA.Name = "grpCategorieA";
            this.grpCategorieA.Size = new System.Drawing.Size(432, 55);
            this.grpCategorieA.TabIndex = 0;
            this.grpCategorieA.TabStop = false;
            this.grpCategorieA.Text = "Categorie";
            // 
            // radOuvrageA
            // 
            this.radOuvrageA.AutoSize = true;
            this.radOuvrageA.Font = new System.Drawing.Font("Arial", 12F);
            this.radOuvrageA.ForeColor = System.Drawing.Color.DarkOrange;
            this.radOuvrageA.Location = new System.Drawing.Point(295, 26);
            this.radOuvrageA.Name = "radOuvrageA";
            this.radOuvrageA.Size = new System.Drawing.Size(85, 22);
            this.radOuvrageA.TabIndex = 1;
            this.radOuvrageA.TabStop = true;
            this.radOuvrageA.Text = "Ouvrage";
            this.radOuvrageA.UseVisualStyleBackColor = true;
            // 
            // radDvdA
            // 
            this.radDvdA.AutoSize = true;
            this.radDvdA.Font = new System.Drawing.Font("Arial", 12F);
            this.radDvdA.ForeColor = System.Drawing.Color.DarkOrange;
            this.radDvdA.Location = new System.Drawing.Point(11, 26);
            this.radDvdA.Name = "radDvdA";
            this.radDvdA.Size = new System.Drawing.Size(54, 22);
            this.radDvdA.TabIndex = 0;
            this.radDvdA.TabStop = true;
            this.radDvdA.Text = "Dvd";
            this.radDvdA.UseVisualStyleBackColor = true;
            // 
            // txtNReferenceA
            // 
            this.txtNReferenceA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNReferenceA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNReferenceA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNReferenceA.Location = new System.Drawing.Point(267, 334);
            this.txtNReferenceA.Name = "txtNReferenceA";
            this.txtNReferenceA.Size = new System.Drawing.Size(73, 19);
            this.txtNReferenceA.TabIndex = 8;
            this.txtNReferenceA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReferenceA
            // 
            this.txtReferenceA.BackColor = System.Drawing.Color.Bisque;
            this.txtReferenceA.Location = new System.Drawing.Point(142, 66);
            this.txtReferenceA.Name = "txtReferenceA";
            this.txtReferenceA.Size = new System.Drawing.Size(281, 31);
            this.txtReferenceA.TabIndex = 12;
            // 
            // txtNomA
            // 
            this.txtNomA.BackColor = System.Drawing.Color.Bisque;
            this.txtNomA.Location = new System.Drawing.Point(142, 28);
            this.txtNomA.Name = "txtNomA";
            this.txtNomA.Size = new System.Drawing.Size(281, 31);
            this.txtNomA.TabIndex = 11;
            // 
            // labReferenceA
            // 
            this.labReferenceA.AutoSize = true;
            this.labReferenceA.ForeColor = System.Drawing.Color.Bisque;
            this.labReferenceA.Location = new System.Drawing.Point(27, 74);
            this.labReferenceA.Name = "labReferenceA";
            this.labReferenceA.Size = new System.Drawing.Size(93, 23);
            this.labReferenceA.TabIndex = 10;
            this.labReferenceA.Text = "Reference";
            // 
            // labNomA
            // 
            this.labNomA.AutoSize = true;
            this.labNomA.ForeColor = System.Drawing.Color.Bisque;
            this.labNomA.Location = new System.Drawing.Point(27, 36);
            this.labNomA.Name = "labNomA";
            this.labNomA.Size = new System.Drawing.Size(50, 23);
            this.labNomA.TabIndex = 9;
            this.labNomA.Text = "Nom";
            // 
            // labNCatalogueA
            // 
            this.labNCatalogueA.AutoSize = true;
            this.labNCatalogueA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labNCatalogueA.ForeColor = System.Drawing.Color.Bisque;
            this.labNCatalogueA.Location = new System.Drawing.Point(348, 337);
            this.labNCatalogueA.Name = "labNCatalogueA";
            this.labNCatalogueA.Size = new System.Drawing.Size(75, 16);
            this.labNCatalogueA.TabIndex = 13;
            this.labNCatalogueA.Text = "catalogues";
            // 
            // grpDvdA
            // 
            this.grpDvdA.Controls.Add(this.txtDureeA);
            this.grpDvdA.Controls.Add(this.labDureeA);
            this.grpDvdA.ForeColor = System.Drawing.Color.Salmon;
            this.grpDvdA.Location = new System.Drawing.Point(6, 272);
            this.grpDvdA.Name = "grpDvdA";
            this.grpDvdA.Size = new System.Drawing.Size(432, 55);
            this.grpDvdA.TabIndex = 2;
            this.grpDvdA.TabStop = false;
            this.grpDvdA.Text = "Dvd";
            // 
            // txtDureeA
            // 
            this.txtDureeA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDureeA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDureeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDureeA.Location = new System.Drawing.Point(92, 24);
            this.txtDureeA.Name = "txtDureeA";
            this.txtDureeA.Size = new System.Drawing.Size(310, 19);
            this.txtDureeA.TabIndex = 10;
            this.txtDureeA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labDureeA
            // 
            this.labDureeA.AutoSize = true;
            this.labDureeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labDureeA.ForeColor = System.Drawing.Color.Bisque;
            this.labDureeA.Location = new System.Drawing.Point(10, 27);
            this.labDureeA.Name = "labDureeA";
            this.labDureeA.Size = new System.Drawing.Size(45, 16);
            this.labDureeA.TabIndex = 9;
            this.labDureeA.Text = "Durée";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Bisque;
            this.checkBox1.Location = new System.Drawing.Point(158, 372);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 27);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Commandé";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Fenetre_article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 472);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.grpClients);
            this.Name = "Fenetre_article";
            this.Text = "Fenetre_article";
            this.grpClients.ResumeLayout(false);
            this.grpClients.PerformLayout();
            this.grpCategorieA.ResumeLayout(false);
            this.grpCategorieA.PerformLayout();
            this.grpDvdA.ResumeLayout(false);
            this.grpDvdA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.GroupBox grpClients;
        private System.Windows.Forms.TextBox txtPrixHTA;
        private System.Windows.Forms.TextBox txtEditeurA;
        private System.Windows.Forms.Label labPrixHTA;
        private System.Windows.Forms.Label labEditeurA;
        private System.Windows.Forms.Label labReferencedansA;
        private System.Windows.Forms.GroupBox grpCategorieA;
        private System.Windows.Forms.RadioButton radOuvrageA;
        private System.Windows.Forms.RadioButton radDvdA;
        private System.Windows.Forms.TextBox txtReferenceA;
        private System.Windows.Forms.TextBox txtNomA;
        private System.Windows.Forms.TextBox txtNReferenceA;
        private System.Windows.Forms.Label labReferenceA;
        private System.Windows.Forms.Label labNomA;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox grpDvdA;
        private System.Windows.Forms.TextBox txtDureeA;
        private System.Windows.Forms.Label labDureeA;
        private System.Windows.Forms.Label labNCatalogueA;
    }
}