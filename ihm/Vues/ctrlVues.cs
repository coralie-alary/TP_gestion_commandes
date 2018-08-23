using ihm.Controleur;
using IHM.Vues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ihm.Vues
{
    public class ctrlVues
    {

        private ctrlPrincipal _ctrl;

        private Fenetre_gestion _fg;
        private Fenetre_panier _fp;
        private Fenetre_client _fc;
        private Fenetre_article _fa;

        public ctrlVues(ctrlPrincipal ctrl)
        {
            this._ctrl = ctrl;

            this._fg = new Fenetre_gestion(this);
            this._fp = new Fenetre_panier(this);
            this._fc = new Fenetre_client(this);
            this._fa = new Fenetre_article(this);

            this._fg.Text = "Fenetre de Gestion (Copyright CA-JAM 2018)";
            this._fp.Text = "Fenetre de Gestion du Panier (Copyright CA-JAM 2018)";
            this._fc.Text = "Fenetre de Gestion des Clients (Copyright CA-JAM 2018)";
            this._fa.Text = "Fenetre d'information sur les articles (Copyright CA-JAM 2018)";

            PositionForm(this._fg, 20, 50);
            PositionForm(this._fp, this._fg.Top, this._fg.Right);
            PositionForm(this._fc, this._fp.Top, this._fp.Right);
            PositionForm(this._fa, this._fp.Bottom, this._fp.Left);

            this._fg.Show();
        }


        public bool encours
        {
            get
            {
                bool ok;

                ok = !this._fg.IsDisposed;

                return ok;
            }
        }

        internal void AfficherFenetre_gestion()
        {
        }

        

        public static bool Confirmer(string question)
        {
            DialogResult dr;

            dr = MessageBox.Show(question +" ?",
                "FENETRE DE CONFIRMATION",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (dr == DialogResult.Yes) return (true);

            return (false);
        }

        public void Vider()
            //si oui efface dans Fenetre_panier toute ce qu'il y a dans listArt
            // laisse Fenetre_panier ouverte
        {
            if (Confirmer("Voulez vous détruire le panier ?") == true)
            {
                this._ctrl.Vider();
                
            }
        }

        //PARAMETRES POSITION FENETRES
        private void PositionForm(Form f, int top, int left)
        {
            //Gestioner de la position des fenêtre
            f.StartPosition = FormStartPosition.Manual;
            f.Top = top;
            f.Left = left;
            f.FormBorderStyle = FormBorderStyle.FixedSingle;
            f.MaximizeBox = false;
        }

        public void AfficherFenetre_panier()
        {
            this._fp.Show();
        }

        public void AfficherFenetre_client()
        {
            this._fc.Show();
        }

        public void AfficherFenetre_article()
        {
            this._fa.Show();
        }


        public void Annuler()
        {
            // si oui annule la commande
            if (Confirmer("Voulez vous annuler la commande (aucun client) ?") == true)
            {
                this._ctrl.Annuler();

            }
        }


        public void Supprimer()
        //si oui efface dans Fenetre_panier UNE LIGNE
        // laisse Fenetre_panier ouverte
        {
            if (Confirmer("Voulez vous supprimer l'article ?") == true)
            {
                this._ctrl.Supprimer();

            }
        }

        public void AfficherNomCatalogues(object catalogue)
        {
            this._fg.comboCatalogue.Items.Add(catalogue);
            this._fg.comboCatalogue.SelectedIndex = 0;
        }

        public void ClearListCatalogues()
        {
            this._fg.listArt.Items.Clear();
        }

        public void AffichageCatalogues(object obj)
        {
            this._fg.listArt.Items.Add(obj);
        }

        public void CatalogueSelectionne()
        {
            this._ctrl.AffichageCatalogues(this._fg.comboCatalogue.Text); 
        }

        public void NombreArticles(int nombre)
        {
            this._fg.textNbArt.Text = nombre + "";
        }

        public void ValeurFinanciere(double total)
        {
            this._fg.textValFin.Text = total + "";
        }

        #region CLIENTS
        public void AfficherClients(object obj)
        {
            this._fg.comboGestionClient.Items.Add(obj);
            this._fg.comboGestionClient.SelectedIndex = 0;
        }

        public void NombreClients(int nbclients)
        {
            this._fg.textGestionClients.Text = nbclients + "";
        }

        public void ClientSelectionne()
        {
           this._ctrl.AffichageClient(this._fg.comboGestionClient.SelectedIndex);
        }

        public void AffichageNomClient(string nom)
        {
            this._fg.textGestionNom.Text = nom;
        }

        public void AffichageIdentifiantClient(string identifiant)
        {
            this._fg.textGestionIdentifiant.Text = identifiant;
        }

        #endregion

    }
}
