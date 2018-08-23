namespace ihm.Vues
{
    partial class Fenetre_panier
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
            this.grpPanier = new System.Windows.Forms.GroupBox();
            this.listArt = new System.Windows.Forms.ListBox();
            this.textPanierNumCom = new System.Windows.Forms.TextBox();
            this.labNumCom = new System.Windows.Forms.Label();
            this.textPanierNbArt = new System.Windows.Forms.TextBox();
            this.labArt = new System.Windows.Forms.Label();
            this.labNbArt = new System.Windows.Forms.Label();
            this.labQte = new System.Windows.Forms.Label();
            this.comboPanier = new System.Windows.Forms.ComboBox();
            this.textPanierTVA = new System.Windows.Forms.TextBox();
            this.labPanierTVA = new System.Windows.Forms.Label();
            this.textPanierPrixTTC = new System.Windows.Forms.TextBox();
            this.labPanierPrixTTC = new System.Windows.Forms.Label();
            this.textPanierHT = new System.Windows.Forms.TextBox();
            this.labPanierPrixHT = new System.Windows.Forms.Label();
            this.btnVider = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnPanierFermer = new System.Windows.Forms.Button();
            this.grpPanier.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPanier
            // 
            this.grpPanier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.grpPanier.Controls.Add(this.btnVider);
            this.grpPanier.Controls.Add(this.btnSupprimer);
            this.grpPanier.Controls.Add(this.textPanierTVA);
            this.grpPanier.Controls.Add(this.labPanierTVA);
            this.grpPanier.Controls.Add(this.textPanierPrixTTC);
            this.grpPanier.Controls.Add(this.labPanierPrixTTC);
            this.grpPanier.Controls.Add(this.textPanierHT);
            this.grpPanier.Controls.Add(this.labPanierPrixHT);
            this.grpPanier.Controls.Add(this.listArt);
            this.grpPanier.Controls.Add(this.textPanierNumCom);
            this.grpPanier.Controls.Add(this.labNumCom);
            this.grpPanier.Controls.Add(this.textPanierNbArt);
            this.grpPanier.Controls.Add(this.labArt);
            this.grpPanier.Controls.Add(this.labNbArt);
            this.grpPanier.Controls.Add(this.labQte);
            this.grpPanier.Controls.Add(this.comboPanier);
            this.grpPanier.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPanier.ForeColor = System.Drawing.Color.Salmon;
            this.grpPanier.Location = new System.Drawing.Point(12, 12);
            this.grpPanier.Name = "grpPanier";
            this.grpPanier.Size = new System.Drawing.Size(594, 393);
            this.grpPanier.TabIndex = 1;
            this.grpPanier.TabStop = false;
            this.grpPanier.Text = "Panier";
            // 
            // listArt
            // 
            this.listArt.BackColor = System.Drawing.Color.Bisque;
            this.listArt.FormattingEnabled = true;
            this.listArt.ItemHeight = 23;
            this.listArt.Location = new System.Drawing.Point(6, 69);
            this.listArt.Name = "listArt";
            this.listArt.Size = new System.Drawing.Size(575, 142);
            this.listArt.TabIndex = 8;
            // 
            // textPanierNumCom
            // 
            this.textPanierNumCom.BackColor = System.Drawing.Color.Bisque;
            this.textPanierNumCom.Location = new System.Drawing.Point(375, 23);
            this.textPanierNumCom.Name = "textPanierNumCom";
            this.textPanierNumCom.Size = new System.Drawing.Size(208, 31);
            this.textPanierNumCom.TabIndex = 7;
            // 
            // labNumCom
            // 
            this.labNumCom.AutoSize = true;
            this.labNumCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumCom.ForeColor = System.Drawing.Color.Bisque;
            this.labNumCom.Location = new System.Drawing.Point(223, 31);
            this.labNumCom.Name = "labNumCom";
            this.labNumCom.Size = new System.Drawing.Size(146, 16);
            this.labNumCom.TabIndex = 6;
            this.labNumCom.Text = "Numero de commande";
            // 
            // textPanierNbArt
            // 
            this.textPanierNbArt.BackColor = System.Drawing.Color.Bisque;
            this.textPanierNbArt.Location = new System.Drawing.Point(84, 23);
            this.textPanierNbArt.Name = "textPanierNbArt";
            this.textPanierNbArt.Size = new System.Drawing.Size(86, 31);
            this.textPanierNbArt.TabIndex = 5;
            // 
            // labArt
            // 
            this.labArt.AutoSize = true;
            this.labArt.BackColor = System.Drawing.Color.PeachPuff;
            this.labArt.Location = new System.Drawing.Point(229, 31);
            this.labArt.Name = "labArt";
            this.labArt.Size = new System.Drawing.Size(0, 23);
            this.labArt.TabIndex = 4;
            // 
            // labNbArt
            // 
            this.labNbArt.AutoSize = true;
            this.labNbArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNbArt.ForeColor = System.Drawing.Color.Bisque;
            this.labNbArt.Location = new System.Drawing.Point(6, 31);
            this.labNbArt.Name = "labNbArt";
            this.labNbArt.Size = new System.Drawing.Size(72, 16);
            this.labNbArt.TabIndex = 3;
            this.labNbArt.Text = "Nb articles";
            // 
            // labQte
            // 
            this.labQte.AutoSize = true;
            this.labQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQte.ForeColor = System.Drawing.Color.Bisque;
            this.labQte.Location = new System.Drawing.Point(6, 233);
            this.labQte.Name = "labQte";
            this.labQte.Size = new System.Drawing.Size(57, 16);
            this.labQte.TabIndex = 2;
            this.labQte.Text = "Quantite";
            // 
            // comboPanier
            // 
            this.comboPanier.BackColor = System.Drawing.Color.Bisque;
            this.comboPanier.FormattingEnabled = true;
            this.comboPanier.Location = new System.Drawing.Point(9, 264);
            this.comboPanier.Name = "comboPanier";
            this.comboPanier.Size = new System.Drawing.Size(121, 31);
            this.comboPanier.TabIndex = 1;
            // 
            // textPanierTVA
            // 
            this.textPanierTVA.BackColor = System.Drawing.Color.LightSlateGray;
            this.textPanierTVA.Location = new System.Drawing.Point(307, 343);
            this.textPanierTVA.Name = "textPanierTVA";
            this.textPanierTVA.Size = new System.Drawing.Size(273, 31);
            this.textPanierTVA.TabIndex = 17;
            // 
            // labPanierTVA
            // 
            this.labPanierTVA.AutoSize = true;
            this.labPanierTVA.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPanierTVA.ForeColor = System.Drawing.Color.Bisque;
            this.labPanierTVA.Location = new System.Drawing.Point(241, 349);
            this.labPanierTVA.Name = "labPanierTVA";
            this.labPanierTVA.Size = new System.Drawing.Size(39, 19);
            this.labPanierTVA.TabIndex = 16;
            this.labPanierTVA.Text = "TVA";
            // 
            // textPanierPrixTTC
            // 
            this.textPanierPrixTTC.BackColor = System.Drawing.Color.LightSlateGray;
            this.textPanierPrixTTC.Location = new System.Drawing.Point(307, 284);
            this.textPanierPrixTTC.Name = "textPanierPrixTTC";
            this.textPanierPrixTTC.Size = new System.Drawing.Size(273, 31);
            this.textPanierPrixTTC.TabIndex = 15;
            // 
            // labPanierPrixTTC
            // 
            this.labPanierPrixTTC.AutoSize = true;
            this.labPanierPrixTTC.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPanierPrixTTC.ForeColor = System.Drawing.Color.Bisque;
            this.labPanierPrixTTC.Location = new System.Drawing.Point(239, 290);
            this.labPanierPrixTTC.Name = "labPanierPrixTTC";
            this.labPanierPrixTTC.Size = new System.Drawing.Size(67, 19);
            this.labPanierPrixTTC.TabIndex = 14;
            this.labPanierPrixTTC.Text = "Prix TTC";
            // 
            // textPanierHT
            // 
            this.textPanierHT.BackColor = System.Drawing.Color.LightSlateGray;
            this.textPanierHT.Location = new System.Drawing.Point(307, 225);
            this.textPanierHT.Name = "textPanierHT";
            this.textPanierHT.Size = new System.Drawing.Size(273, 31);
            this.textPanierHT.TabIndex = 13;
            // 
            // labPanierPrixHT
            // 
            this.labPanierPrixHT.AutoSize = true;
            this.labPanierPrixHT.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPanierPrixHT.ForeColor = System.Drawing.Color.Bisque;
            this.labPanierPrixHT.Location = new System.Drawing.Point(241, 233);
            this.labPanierPrixHT.Name = "labPanierPrixHT";
            this.labPanierPrixHT.Size = new System.Drawing.Size(60, 19);
            this.labPanierPrixHT.TabIndex = 12;
            this.labPanierPrixHT.Text = "Prix HT";
            // 
            // btnVider
            // 
            this.btnVider.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnVider.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.ForeColor = System.Drawing.Color.Black;
            this.btnVider.Location = new System.Drawing.Point(95, 313);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(75, 31);
            this.btnVider.TabIndex = 19;
            this.btnVider.Text = "Vider";
            this.btnVider.UseVisualStyleBackColor = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSupprimer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.Black;
            this.btnSupprimer.Location = new System.Drawing.Point(9, 313);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 31);
            this.btnSupprimer.TabIndex = 18;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            // 
            // btnPanierFermer
            // 
            this.btnPanierFermer.BackColor = System.Drawing.Color.Firebrick;
            this.btnPanierFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanierFermer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPanierFermer.Location = new System.Drawing.Point(257, 420);
            this.btnPanierFermer.Name = "btnPanierFermer";
            this.btnPanierFermer.Size = new System.Drawing.Size(100, 34);
            this.btnPanierFermer.TabIndex = 3;
            this.btnPanierFermer.Text = "Fermer";
            this.btnPanierFermer.UseVisualStyleBackColor = false;
            // 
            // Fenetre_panier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 465);
            this.Controls.Add(this.btnPanierFermer);
            this.Controls.Add(this.grpPanier);
            this.Name = "Fenetre_panier";
            this.Text = "Fenetre_panier";
            this.grpPanier.ResumeLayout(false);
            this.grpPanier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPanier;
        private System.Windows.Forms.ListBox listArt;
        private System.Windows.Forms.TextBox textPanierNumCom;
        private System.Windows.Forms.Label labNumCom;
        private System.Windows.Forms.TextBox textPanierNbArt;
        private System.Windows.Forms.Label labArt;
        private System.Windows.Forms.Label labNbArt;
        private System.Windows.Forms.Label labQte;
        private System.Windows.Forms.ComboBox comboPanier;
        private System.Windows.Forms.TextBox textPanierTVA;
        private System.Windows.Forms.Label labPanierTVA;
        private System.Windows.Forms.TextBox textPanierPrixTTC;
        private System.Windows.Forms.Label labPanierPrixTTC;
        private System.Windows.Forms.TextBox textPanierHT;
        private System.Windows.Forms.Label labPanierPrixHT;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnPanierFermer;
    }
}