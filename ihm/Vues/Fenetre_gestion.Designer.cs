namespace ihm.Vues
{
    partial class Fenetre_gestion
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
            this.grpGestionCatalogue = new System.Windows.Forms.GroupBox();
            this.listArt = new System.Windows.Forms.ListBox();
            this.btnInterrogation = new System.Windows.Forms.Button();
            this.textValFin = new System.Windows.Forms.TextBox();
            this.labValFin = new System.Windows.Forms.Label();
            this.textNbArt = new System.Windows.Forms.TextBox();
            this.labArt = new System.Windows.Forms.Label();
            this.labNbArt = new System.Windows.Forms.Label();
            this.labCatalogue = new System.Windows.Forms.Label();
            this.comboCatalogue = new System.Windows.Forms.ComboBox();
            this.btnGestionQuitter = new System.Windows.Forms.Button();
            this.grpGestionPanier = new System.Windows.Forms.GroupBox();
            this.btnGestionAfficher = new System.Windows.Forms.Button();
            this.btnGestionVider = new System.Windows.Forms.Button();
            this.btnGestionAjouter = new System.Windows.Forms.Button();
            this.textGestionTVA = new System.Windows.Forms.TextBox();
            this.labGestionTVA = new System.Windows.Forms.Label();
            this.textGestionPrixTTC = new System.Windows.Forms.TextBox();
            this.labGestionPrixTTC = new System.Windows.Forms.Label();
            this.textGestionPrixHT = new System.Windows.Forms.TextBox();
            this.labGestionPrixHT = new System.Windows.Forms.Label();
            this.textQt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labQt = new System.Windows.Forms.Label();
            this.grpGestionChoixClients = new System.Windows.Forms.GroupBox();
            this.btnGestionAnnuler = new System.Windows.Forms.Button();
            this.groupGestionCategorie = new System.Windows.Forms.GroupBox();
            this.radioButtonGestionProfessionnel = new System.Windows.Forms.RadioButton();
            this.radioButtonGestionParticulier = new System.Windows.Forms.RadioButton();
            this.comboGestionClient = new System.Windows.Forms.ComboBox();
            this.btnGestionChoixAfficher = new System.Windows.Forms.Button();
            this.textGestionIdentifiant = new System.Windows.Forms.TextBox();
            this.labGestionIdentifiant = new System.Windows.Forms.Label();
            this.textGestionNom = new System.Windows.Forms.TextBox();
            this.labGestionNom = new System.Windows.Forms.Label();
            this.textGestionClients = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labGestionClients = new System.Windows.Forms.Label();
            this.grpProfessionnelC = new System.Windows.Forms.GroupBox();
            this.datCreationC = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grpGestionCatalogue.SuspendLayout();
            this.grpGestionPanier.SuspendLayout();
            this.grpGestionChoixClients.SuspendLayout();
            this.groupGestionCategorie.SuspendLayout();
            this.grpProfessionnelC.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGestionCatalogue
            // 
            this.grpGestionCatalogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.grpGestionCatalogue.Controls.Add(this.listArt);
            this.grpGestionCatalogue.Controls.Add(this.btnInterrogation);
            this.grpGestionCatalogue.Controls.Add(this.textValFin);
            this.grpGestionCatalogue.Controls.Add(this.labValFin);
            this.grpGestionCatalogue.Controls.Add(this.textNbArt);
            this.grpGestionCatalogue.Controls.Add(this.labArt);
            this.grpGestionCatalogue.Controls.Add(this.labNbArt);
            this.grpGestionCatalogue.Controls.Add(this.labCatalogue);
            this.grpGestionCatalogue.Controls.Add(this.comboCatalogue);
            this.grpGestionCatalogue.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGestionCatalogue.ForeColor = System.Drawing.Color.Salmon;
            this.grpGestionCatalogue.Location = new System.Drawing.Point(12, 12);
            this.grpGestionCatalogue.Name = "grpGestionCatalogue";
            this.grpGestionCatalogue.Size = new System.Drawing.Size(325, 302);
            this.grpGestionCatalogue.TabIndex = 0;
            this.grpGestionCatalogue.TabStop = false;
            this.grpGestionCatalogue.Text = "Choix catalogue";
            // 
            // listArt
            // 
            this.listArt.BackColor = System.Drawing.Color.PeachPuff;
            this.listArt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listArt.FormattingEnabled = true;
            this.listArt.ItemHeight = 15;
            this.listArt.Location = new System.Drawing.Point(6, 106);
            this.listArt.Name = "listArt";
            this.listArt.Size = new System.Drawing.Size(275, 184);
            this.listArt.TabIndex = 10;
            // 
            // btnInterrogation
            // 
            this.btnInterrogation.BackColor = System.Drawing.Color.Coral;
            this.btnInterrogation.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterrogation.ForeColor = System.Drawing.Color.Blue;
            this.btnInterrogation.Location = new System.Drawing.Point(287, 165);
            this.btnInterrogation.Name = "btnInterrogation";
            this.btnInterrogation.Size = new System.Drawing.Size(32, 33);
            this.btnInterrogation.TabIndex = 9;
            this.btnInterrogation.Text = "?";
            this.btnInterrogation.UseVisualStyleBackColor = false;
            // 
            // textValFin
            // 
            this.textValFin.BackColor = System.Drawing.Color.Bisque;
            this.textValFin.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValFin.Location = new System.Drawing.Point(229, 65);
            this.textValFin.Name = "textValFin";
            this.textValFin.Size = new System.Drawing.Size(86, 22);
            this.textValFin.TabIndex = 7;
            // 
            // labValFin
            // 
            this.labValFin.AutoSize = true;
            this.labValFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labValFin.ForeColor = System.Drawing.Color.Bisque;
            this.labValFin.Location = new System.Drawing.Point(137, 73);
            this.labValFin.Name = "labValFin";
            this.labValFin.Size = new System.Drawing.Size(92, 16);
            this.labValFin.TabIndex = 6;
            this.labValFin.Text = "Val. financiere";
            // 
            // textNbArt
            // 
            this.textNbArt.BackColor = System.Drawing.Color.Bisque;
            this.textNbArt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNbArt.Location = new System.Drawing.Point(229, 28);
            this.textNbArt.Name = "textNbArt";
            this.textNbArt.Size = new System.Drawing.Size(86, 23);
            this.textNbArt.TabIndex = 5;
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
            this.labNbArt.Location = new System.Drawing.Point(137, 37);
            this.labNbArt.Name = "labNbArt";
            this.labNbArt.Size = new System.Drawing.Size(72, 16);
            this.labNbArt.TabIndex = 3;
            this.labNbArt.Text = "Nb articles";
            // 
            // labCatalogue
            // 
            this.labCatalogue.AutoSize = true;
            this.labCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCatalogue.ForeColor = System.Drawing.Color.Bisque;
            this.labCatalogue.Location = new System.Drawing.Point(6, 37);
            this.labCatalogue.Name = "labCatalogue";
            this.labCatalogue.Size = new System.Drawing.Size(100, 16);
            this.labCatalogue.TabIndex = 2;
            this.labCatalogue.Text = "Les catalogues";
            // 
            // comboCatalogue
            // 
            this.comboCatalogue.BackColor = System.Drawing.Color.Bisque;
            this.comboCatalogue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCatalogue.FormattingEnabled = true;
            this.comboCatalogue.Location = new System.Drawing.Point(6, 58);
            this.comboCatalogue.Name = "comboCatalogue";
            this.comboCatalogue.Size = new System.Drawing.Size(121, 23);
            this.comboCatalogue.TabIndex = 1;
            // 
            // btnGestionQuitter
            // 
            this.btnGestionQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGestionQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionQuitter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGestionQuitter.Location = new System.Drawing.Point(276, 548);
            this.btnGestionQuitter.Name = "btnGestionQuitter";
            this.btnGestionQuitter.Size = new System.Drawing.Size(100, 34);
            this.btnGestionQuitter.TabIndex = 2;
            this.btnGestionQuitter.Text = "Quitter";
            this.btnGestionQuitter.UseVisualStyleBackColor = false;
            // 
            // grpGestionPanier
            // 
            this.grpGestionPanier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.grpGestionPanier.Controls.Add(this.btnGestionAfficher);
            this.grpGestionPanier.Controls.Add(this.btnGestionVider);
            this.grpGestionPanier.Controls.Add(this.btnGestionAjouter);
            this.grpGestionPanier.Controls.Add(this.textGestionTVA);
            this.grpGestionPanier.Controls.Add(this.labGestionTVA);
            this.grpGestionPanier.Controls.Add(this.textGestionPrixTTC);
            this.grpGestionPanier.Controls.Add(this.labGestionPrixTTC);
            this.grpGestionPanier.Controls.Add(this.textGestionPrixHT);
            this.grpGestionPanier.Controls.Add(this.labGestionPrixHT);
            this.grpGestionPanier.Controls.Add(this.textQt);
            this.grpGestionPanier.Controls.Add(this.label3);
            this.grpGestionPanier.Controls.Add(this.labQt);
            this.grpGestionPanier.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGestionPanier.ForeColor = System.Drawing.Color.Salmon;
            this.grpGestionPanier.Location = new System.Drawing.Point(12, 320);
            this.grpGestionPanier.Name = "grpGestionPanier";
            this.grpGestionPanier.Size = new System.Drawing.Size(325, 222);
            this.grpGestionPanier.TabIndex = 4;
            this.grpGestionPanier.TabStop = false;
            this.grpGestionPanier.Text = "Panier";
            // 
            // btnGestionAfficher
            // 
            this.btnGestionAfficher.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGestionAfficher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionAfficher.ForeColor = System.Drawing.Color.Black;
            this.btnGestionAfficher.Location = new System.Drawing.Point(229, 185);
            this.btnGestionAfficher.Name = "btnGestionAfficher";
            this.btnGestionAfficher.Size = new System.Drawing.Size(75, 31);
            this.btnGestionAfficher.TabIndex = 14;
            this.btnGestionAfficher.Text = "Afficher";
            this.btnGestionAfficher.UseVisualStyleBackColor = false;
            // 
            // btnGestionVider
            // 
            this.btnGestionVider.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGestionVider.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionVider.ForeColor = System.Drawing.Color.Black;
            this.btnGestionVider.Location = new System.Drawing.Point(125, 185);
            this.btnGestionVider.Name = "btnGestionVider";
            this.btnGestionVider.Size = new System.Drawing.Size(75, 31);
            this.btnGestionVider.TabIndex = 13;
            this.btnGestionVider.Text = "Vider";
            this.btnGestionVider.UseVisualStyleBackColor = false;
            // 
            // btnGestionAjouter
            // 
            this.btnGestionAjouter.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGestionAjouter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionAjouter.ForeColor = System.Drawing.Color.Black;
            this.btnGestionAjouter.Location = new System.Drawing.Point(19, 185);
            this.btnGestionAjouter.Name = "btnGestionAjouter";
            this.btnGestionAjouter.Size = new System.Drawing.Size(75, 31);
            this.btnGestionAjouter.TabIndex = 12;
            this.btnGestionAjouter.Text = "Ajouter";
            this.btnGestionAjouter.UseVisualStyleBackColor = false;
            // 
            // textGestionTVA
            // 
            this.textGestionTVA.BackColor = System.Drawing.Color.LightSlateGray;
            this.textGestionTVA.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGestionTVA.Location = new System.Drawing.Point(84, 140);
            this.textGestionTVA.Name = "textGestionTVA";
            this.textGestionTVA.Size = new System.Drawing.Size(231, 23);
            this.textGestionTVA.TabIndex = 11;
            // 
            // labGestionTVA
            // 
            this.labGestionTVA.AutoSize = true;
            this.labGestionTVA.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGestionTVA.ForeColor = System.Drawing.Color.Bisque;
            this.labGestionTVA.Location = new System.Drawing.Point(2, 146);
            this.labGestionTVA.Name = "labGestionTVA";
            this.labGestionTVA.Size = new System.Drawing.Size(39, 19);
            this.labGestionTVA.TabIndex = 10;
            this.labGestionTVA.Text = "TVA";
            // 
            // textGestionPrixTTC
            // 
            this.textGestionPrixTTC.BackColor = System.Drawing.Color.LightSlateGray;
            this.textGestionPrixTTC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGestionPrixTTC.Location = new System.Drawing.Point(84, 103);
            this.textGestionPrixTTC.Name = "textGestionPrixTTC";
            this.textGestionPrixTTC.Size = new System.Drawing.Size(231, 23);
            this.textGestionPrixTTC.TabIndex = 9;
            // 
            // labGestionPrixTTC
            // 
            this.labGestionPrixTTC.AutoSize = true;
            this.labGestionPrixTTC.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGestionPrixTTC.ForeColor = System.Drawing.Color.Bisque;
            this.labGestionPrixTTC.Location = new System.Drawing.Point(4, 109);
            this.labGestionPrixTTC.Name = "labGestionPrixTTC";
            this.labGestionPrixTTC.Size = new System.Drawing.Size(67, 19);
            this.labGestionPrixTTC.TabIndex = 8;
            this.labGestionPrixTTC.Text = "Prix TTC";
            // 
            // textGestionPrixHT
            // 
            this.textGestionPrixHT.BackColor = System.Drawing.Color.LightSlateGray;
            this.textGestionPrixHT.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGestionPrixHT.Location = new System.Drawing.Point(84, 65);
            this.textGestionPrixHT.Name = "textGestionPrixHT";
            this.textGestionPrixHT.Size = new System.Drawing.Size(231, 23);
            this.textGestionPrixHT.TabIndex = 7;
            // 
            // labGestionPrixHT
            // 
            this.labGestionPrixHT.AutoSize = true;
            this.labGestionPrixHT.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGestionPrixHT.ForeColor = System.Drawing.Color.Bisque;
            this.labGestionPrixHT.Location = new System.Drawing.Point(4, 71);
            this.labGestionPrixHT.Name = "labGestionPrixHT";
            this.labGestionPrixHT.Size = new System.Drawing.Size(60, 19);
            this.labGestionPrixHT.TabIndex = 6;
            this.labGestionPrixHT.Text = "Prix HT";
            // 
            // textQt
            // 
            this.textQt.BackColor = System.Drawing.Color.Bisque;
            this.textQt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQt.Location = new System.Drawing.Point(154, 23);
            this.textQt.Name = "textQt";
            this.textQt.Size = new System.Drawing.Size(93, 23);
            this.textQt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PeachPuff;
            this.label3.Location = new System.Drawing.Point(229, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 4;
            // 
            // labQt
            // 
            this.labQt.AutoSize = true;
            this.labQt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQt.ForeColor = System.Drawing.Color.Bisque;
            this.labQt.Location = new System.Drawing.Point(6, 31);
            this.labQt.Name = "labQt";
            this.labQt.Size = new System.Drawing.Size(57, 16);
            this.labQt.TabIndex = 3;
            this.labQt.Text = "Quantité";
            // 
            // grpGestionChoixClients
            // 
            this.grpGestionChoixClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.grpGestionChoixClients.Controls.Add(this.grpProfessionnelC);
            this.grpGestionChoixClients.Controls.Add(this.btnGestionAnnuler);
            this.grpGestionChoixClients.Controls.Add(this.groupGestionCategorie);
            this.grpGestionChoixClients.Controls.Add(this.comboGestionClient);
            this.grpGestionChoixClients.Controls.Add(this.btnGestionChoixAfficher);
            this.grpGestionChoixClients.Controls.Add(this.textGestionIdentifiant);
            this.grpGestionChoixClients.Controls.Add(this.labGestionIdentifiant);
            this.grpGestionChoixClients.Controls.Add(this.textGestionNom);
            this.grpGestionChoixClients.Controls.Add(this.labGestionNom);
            this.grpGestionChoixClients.Controls.Add(this.textGestionClients);
            this.grpGestionChoixClients.Controls.Add(this.label10);
            this.grpGestionChoixClients.Controls.Add(this.labGestionClients);
            this.grpGestionChoixClients.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGestionChoixClients.ForeColor = System.Drawing.Color.Salmon;
            this.grpGestionChoixClients.Location = new System.Drawing.Point(352, 12);
            this.grpGestionChoixClients.Name = "grpGestionChoixClients";
            this.grpGestionChoixClients.Size = new System.Drawing.Size(343, 530);
            this.grpGestionChoixClients.TabIndex = 5;
            this.grpGestionChoixClients.TabStop = false;
            this.grpGestionChoixClients.Text = "Choix client";
            // 
            // btnGestionAnnuler
            // 
            this.btnGestionAnnuler.BackColor = System.Drawing.Color.SandyBrown;
            this.btnGestionAnnuler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnGestionAnnuler.Location = new System.Drawing.Point(145, 493);
            this.btnGestionAnnuler.Name = "btnGestionAnnuler";
            this.btnGestionAnnuler.Size = new System.Drawing.Size(75, 31);
            this.btnGestionAnnuler.TabIndex = 15;
            this.btnGestionAnnuler.Text = "Annuler";
            this.btnGestionAnnuler.UseVisualStyleBackColor = false;
            // 
            // groupGestionCategorie
            // 
            this.groupGestionCategorie.Controls.Add(this.radioButtonGestionProfessionnel);
            this.groupGestionCategorie.Controls.Add(this.radioButtonGestionParticulier);
            this.groupGestionCategorie.ForeColor = System.Drawing.Color.Salmon;
            this.groupGestionCategorie.Location = new System.Drawing.Point(13, 293);
            this.groupGestionCategorie.Name = "groupGestionCategorie";
            this.groupGestionCategorie.Size = new System.Drawing.Size(324, 103);
            this.groupGestionCategorie.TabIndex = 14;
            this.groupGestionCategorie.TabStop = false;
            this.groupGestionCategorie.Text = "Categorie";
            // 
            // radioButtonGestionProfessionnel
            // 
            this.radioButtonGestionProfessionnel.AutoSize = true;
            this.radioButtonGestionProfessionnel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGestionProfessionnel.ForeColor = System.Drawing.Color.DarkOrange;
            this.radioButtonGestionProfessionnel.Location = new System.Drawing.Point(19, 69);
            this.radioButtonGestionProfessionnel.Name = "radioButtonGestionProfessionnel";
            this.radioButtonGestionProfessionnel.Size = new System.Drawing.Size(121, 22);
            this.radioButtonGestionProfessionnel.TabIndex = 1;
            this.radioButtonGestionProfessionnel.TabStop = true;
            this.radioButtonGestionProfessionnel.Text = "Professionnel";
            this.radioButtonGestionProfessionnel.UseVisualStyleBackColor = true;
            // 
            // radioButtonGestionParticulier
            // 
            this.radioButtonGestionParticulier.AutoSize = true;
            this.radioButtonGestionParticulier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGestionParticulier.ForeColor = System.Drawing.Color.DarkOrange;
            this.radioButtonGestionParticulier.Location = new System.Drawing.Point(19, 41);
            this.radioButtonGestionParticulier.Name = "radioButtonGestionParticulier";
            this.radioButtonGestionParticulier.Size = new System.Drawing.Size(96, 22);
            this.radioButtonGestionParticulier.TabIndex = 0;
            this.radioButtonGestionParticulier.TabStop = true;
            this.radioButtonGestionParticulier.Text = "Particulier";
            this.radioButtonGestionParticulier.UseVisualStyleBackColor = true;
            // 
            // comboGestionClient
            // 
            this.comboGestionClient.BackColor = System.Drawing.Color.Bisque;
            this.comboGestionClient.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGestionClient.FormattingEnabled = true;
            this.comboGestionClient.Location = new System.Drawing.Point(6, 74);
            this.comboGestionClient.Name = "comboGestionClient";
            this.comboGestionClient.Size = new System.Drawing.Size(331, 23);
            this.comboGestionClient.TabIndex = 13;
            // 
            // btnGestionChoixAfficher
            // 
            this.btnGestionChoixAfficher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGestionChoixAfficher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionChoixAfficher.ForeColor = System.Drawing.Color.Black;
            this.btnGestionChoixAfficher.Location = new System.Drawing.Point(32, 493);
            this.btnGestionChoixAfficher.Name = "btnGestionChoixAfficher";
            this.btnGestionChoixAfficher.Size = new System.Drawing.Size(75, 31);
            this.btnGestionChoixAfficher.TabIndex = 12;
            this.btnGestionChoixAfficher.Text = "Afficher";
            this.btnGestionChoixAfficher.UseVisualStyleBackColor = false;
            // 
            // textGestionIdentifiant
            // 
            this.textGestionIdentifiant.BackColor = System.Drawing.Color.LightSlateGray;
            this.textGestionIdentifiant.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGestionIdentifiant.Location = new System.Drawing.Point(6, 235);
            this.textGestionIdentifiant.Name = "textGestionIdentifiant";
            this.textGestionIdentifiant.Size = new System.Drawing.Size(331, 23);
            this.textGestionIdentifiant.TabIndex = 11;
            // 
            // labGestionIdentifiant
            // 
            this.labGestionIdentifiant.AutoSize = true;
            this.labGestionIdentifiant.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGestionIdentifiant.ForeColor = System.Drawing.Color.Bisque;
            this.labGestionIdentifiant.Location = new System.Drawing.Point(6, 212);
            this.labGestionIdentifiant.Name = "labGestionIdentifiant";
            this.labGestionIdentifiant.Size = new System.Drawing.Size(83, 19);
            this.labGestionIdentifiant.TabIndex = 10;
            this.labGestionIdentifiant.Text = "Identifiant";
            // 
            // textGestionNom
            // 
            this.textGestionNom.BackColor = System.Drawing.Color.LightSlateGray;
            this.textGestionNom.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGestionNom.Location = new System.Drawing.Point(6, 148);
            this.textGestionNom.Name = "textGestionNom";
            this.textGestionNom.Size = new System.Drawing.Size(331, 23);
            this.textGestionNom.TabIndex = 9;
            // 
            // labGestionNom
            // 
            this.labGestionNom.AutoSize = true;
            this.labGestionNom.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGestionNom.ForeColor = System.Drawing.Color.Bisque;
            this.labGestionNom.Location = new System.Drawing.Point(5, 126);
            this.labGestionNom.Name = "labGestionNom";
            this.labGestionNom.Size = new System.Drawing.Size(44, 19);
            this.labGestionNom.TabIndex = 8;
            this.labGestionNom.Text = "Nom";
            // 
            // textGestionClients
            // 
            this.textGestionClients.BackColor = System.Drawing.Color.Bisque;
            this.textGestionClients.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGestionClients.Location = new System.Drawing.Point(154, 23);
            this.textGestionClients.Name = "textGestionClients";
            this.textGestionClients.Size = new System.Drawing.Size(142, 23);
            this.textGestionClients.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.PeachPuff;
            this.label10.Location = new System.Drawing.Point(229, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 23);
            this.label10.TabIndex = 4;
            // 
            // labGestionClients
            // 
            this.labGestionClients.AutoSize = true;
            this.labGestionClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGestionClients.ForeColor = System.Drawing.Color.Bisque;
            this.labGestionClients.Location = new System.Drawing.Point(6, 31);
            this.labGestionClients.Name = "labGestionClients";
            this.labGestionClients.Size = new System.Drawing.Size(71, 16);
            this.labGestionClients.TabIndex = 3;
            this.labGestionClients.Text = "Les clients";
            // 
            // grpProfessionnelC
            // 
            this.grpProfessionnelC.Controls.Add(this.datCreationC);
            this.grpProfessionnelC.Controls.Add(this.label1);
            this.grpProfessionnelC.ForeColor = System.Drawing.Color.Salmon;
            this.grpProfessionnelC.Location = new System.Drawing.Point(13, 417);
            this.grpProfessionnelC.Name = "grpProfessionnelC";
            this.grpProfessionnelC.Size = new System.Drawing.Size(324, 55);
            this.grpProfessionnelC.TabIndex = 19;
            this.grpProfessionnelC.TabStop = false;
            this.grpProfessionnelC.Text = "Professionnel";
            // 
            // datCreationC
            // 
            this.datCreationC.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datCreationC.Location = new System.Drawing.Point(108, 23);
            this.datCreationC.Name = "datCreationC";
            this.datCreationC.Size = new System.Drawing.Size(210, 20);
            this.datCreationC.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Date de création";
            // 
            // Fenetre_gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 587);
            this.Controls.Add(this.grpGestionChoixClients);
            this.Controls.Add(this.grpGestionPanier);
            this.Controls.Add(this.btnGestionQuitter);
            this.Controls.Add(this.grpGestionCatalogue);
            this.Name = "Fenetre_gestion";
            this.Text = "Fenetre_gestion";
            this.grpGestionCatalogue.ResumeLayout(false);
            this.grpGestionCatalogue.PerformLayout();
            this.grpGestionPanier.ResumeLayout(false);
            this.grpGestionPanier.PerformLayout();
            this.grpGestionChoixClients.ResumeLayout(false);
            this.grpGestionChoixClients.PerformLayout();
            this.groupGestionCategorie.ResumeLayout(false);
            this.groupGestionCategorie.PerformLayout();
            this.grpProfessionnelC.ResumeLayout(false);
            this.grpProfessionnelC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGestionCatalogue;
        private System.Windows.Forms.Button btnGestionQuitter;
        private System.Windows.Forms.Label labCatalogue;
        private System.Windows.Forms.Label labNbArt;
        private System.Windows.Forms.Label labArt;
        private System.Windows.Forms.Label labValFin;
        private System.Windows.Forms.GroupBox grpGestionPanier;
        private System.Windows.Forms.Label labGestionTVA;
        private System.Windows.Forms.Label labGestionPrixTTC;
        private System.Windows.Forms.Label labGestionPrixHT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labQt;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox comboCatalogue;
        public System.Windows.Forms.TextBox textNbArt;
        public System.Windows.Forms.TextBox textValFin;
        public System.Windows.Forms.Button btnGestionAfficher;
        public System.Windows.Forms.Button btnGestionVider;
        public System.Windows.Forms.Button btnGestionAjouter;
        public System.Windows.Forms.TextBox textGestionTVA;
        public System.Windows.Forms.TextBox textGestionPrixTTC;
        public System.Windows.Forms.TextBox textGestionPrixHT;
        public System.Windows.Forms.TextBox textQt;
        public System.Windows.Forms.ComboBox comboGestionClient;
        public System.Windows.Forms.Button btnGestionChoixAfficher;
        public System.Windows.Forms.TextBox textGestionIdentifiant;
        public System.Windows.Forms.Label labGestionIdentifiant;
        public System.Windows.Forms.TextBox textGestionNom;
        public System.Windows.Forms.Label labGestionNom;
        public System.Windows.Forms.TextBox textGestionClients;
        public System.Windows.Forms.Label labGestionClients;
        public System.Windows.Forms.GroupBox groupGestionCategorie;
        public System.Windows.Forms.Button btnGestionAnnuler;
        public System.Windows.Forms.RadioButton radioButtonGestionProfessionnel;
        public System.Windows.Forms.RadioButton radioButtonGestionParticulier;
        public System.Windows.Forms.ListBox listArt;
        public System.Windows.Forms.Button btnInterrogation;
        public System.Windows.Forms.DateTimePicker datCreationC;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox grpGestionChoixClients;
        public System.Windows.Forms.GroupBox grpProfessionnelC;
    }
}