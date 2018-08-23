using ihm.Vues;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM.Vues
{
    public partial class Fenetre_article : Form
    {
        ctrlVues _cv;

        public Fenetre_article(ctrlVues cv)
        {
            this._cv = cv;
            this.InitializeComponent();
            this.InitialiserCB();
            this.InitaliserIhm();
        }

        private void InitaliserIhm()
        {

        }

        private void InitialiserCB()
        {
            this.btnFermer.Click += this.CBArticleFermer;
            this.FormClosing += this.CBArticleQuitter;
        }

        private void CBArticleFermer(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CBArticleQuitter(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

    }
}
