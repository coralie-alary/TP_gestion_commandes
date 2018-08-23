using Modele;
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
    public partial class Fenetre_panier : Form
    {
        private ctrlVues _cv;

        void InitialiserCB()
        {
            this.btnSupprimer.Click += CBbtnSupprimer;
            this.btnVider.Click += CBbtnVider;
            this.btnPanierFermer.Click += CBbtnPanierFermer;

            this.FormClosing += this.CBQuitter;
        }

        private void CBQuitter(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();  // ne ferme pas la fenetre panier , l'a cache seulement
        }

        private void CBbtnPanierFermer(object sender, EventArgs e)
        {
            // fermer la fenetre_panier
            this.Close();
        }

        private void CBbtnVider(object sender, EventArgs e)
        {
            //efface le panier mais laisse la fenetre panier ouverte
            // meme EVENEMENT que bouton vider de fenetre_gestion
            this._cv.Vider();
        }


        //fenetre de confirmation
        private void CBbtnSupprimer(object sender, EventArgs e)
        {
            this._cv.Supprimer();
        }

        private void Initialiserihm()
        {

        }

        //******************************************
        // pour afficher la ligne dans la fenetre _ panier
        public void Afficher(string s)
        {
            this.listArt.Items.Add(s);
        }

        public void Afficher(List<article> _list)
        {
            this.listArt.Items.Clear();
            foreach (article o in _list)
                this.listArt.Items.Add(o);
        }
        //*****************************************

        public Fenetre_panier(ctrlVues cv)
        {
            this._cv = cv;
            InitializeComponent();
            this.InitialiserCB();
            this.Initialiserihm();
        }

      
    }
}
