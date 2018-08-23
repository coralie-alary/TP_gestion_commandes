using ihm.Controleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ihm.Vues
{
    public partial class Fenetre_gestion : Form
    {
        private ctrlVues _cv;

        private void InitialiserCB()
        {
            this.comboCatalogue.SelectedIndexChanged += this.CBGestionCatalogue;

            this.comboGestionClient.SelectedIndexChanged += CBGestionClients;    

            this.btnGestionAjouter.Click += this.CBGestionAjouter;
            this.btnGestionVider.Click += this.CBGestionVider;
            this.btnGestionAfficher.Click += this.CBGestionAfficher;
            this.btnGestionChoixAfficher.Click += this.CBGestionChoixAfficher;
            this.btnGestionAnnuler.Click += this.CBGestionAnnuler;
            this.btnGestionQuitter.Click += this.CBQuitter;
            this.btnInterrogation.Click += this.CBInterrogation;
            this.FormClosing += this.CBQuitter;

         //***************************************************************************   
            this.radioButtonGestionParticulier.CheckedChanged += this.CBParticulier;      // check particulier
            this.radioButtonGestionProfessionnel.CheckedChanged += this.CBprofessionnel; // check professionnel
        }

       
        private void CBprofessionnel(object sender, EventArgs e) //événement si professionnel selectionné
        {
            this.AfficherDateProfessionnel(); // affiche date création
        }
       
        private void AfficherDateProfessionnel()
        {
            this.grpProfessionnelC.Visible = this.radioButtonGestionProfessionnel.Checked;
        }

        private void CBParticulier(object sender, EventArgs e) //événement si professionnel selectionné 
        {
            this.grpProfessionnelC.Hide();   // -> grp catégorie caché
        }
        //***************************************************************************


        private void CBGestionClients(object sender, EventArgs e)
        {
            this._cv.ClientSelectionne();
        }

        private void CBGestionCatalogue(object sender, EventArgs e)
        {
            this._cv.CatalogueSelectionne();
        }

        private void CBInterrogation(object sender, EventArgs e)
        {
            this._cv.AfficherFenetre_article();
        }

        private void CBQuitter(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBQuitter(object sender, FormClosingEventArgs e)
        {
            if (ctrlVues.Confirmer("Voulez vous quitter l'application") == false)
                e.Cancel = true;
        }

        //fenetre de confirmation
        private void CBGestionAnnuler(object sender, EventArgs e)
        {
            this._cv.Annuler();
        }

        //BOUTON AFFICHER DU GROUP BOX CHOIX CLIENT 
        private void CBGestionChoixAfficher(object sender, EventArgs e)
        {
            this._cv.AfficherFenetre_client();
        }

        //BOUTON AFFICHER DU GROUP BOX CHOIX CATALOGUE
        private void CBGestionAfficher(object sender, EventArgs e)
        {
            this._cv.AfficherFenetre_gestion();
            this._cv.AfficherFenetre_panier(); //affiche Fenetre_panier
        }

        //fenetre de confirmation
        private void CBGestionVider(object sender, EventArgs e)
        {
            this._cv.Vider();
        }

        private void CBGestionAjouter(object sender, EventArgs e)
        {
            // ajoute une ligne de commande dans Fenetre_panier -> listArt
        }

        private void Initialiserihm()
        {
            //this._cv.CatalogueSelectionne();
        }

        public Fenetre_gestion(ctrlVues cv)
        {
            this._cv = cv;
            this.InitializeComponent();
            this.InitialiserCB();
            this.Initialiserihm();

        }

    }


}
