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
    public partial class Fenetre_client : Form
    {
        ctrlVues _cv;

        public Fenetre_client(ctrlVues cv)
        {
            this._cv = cv;

            this.InitializeComponent();
            this.InitialiserCB();
            this.InitialiserIhm();
        }

        private void InitialiserIhm()
        {

        }

        private void InitialiserCB()
        {
            this.btnAjouter.Click += this.CBClientAjouter;
            this.btnModifier.Click += this.CBClientModifier;
            this.btnEffacer.Click += this.CBClientEffacer;
            this.btnFermer.Click += this.CBClientFermer;

            this.FormClosing += this.CBClientQuitter;
        }

        private void CBClientEffacer(object sender, EventArgs e)
        {
            
        }

        private void CBClientModifier(object sender, EventArgs e)
        {
            
        }

        private void CBClientAjouter(object sender, EventArgs e)
        {
            
        }

        private void CBClientFermer(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBClientQuitter(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }


    }
}
