using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class ArtPanier
    {
        #region attributs d'instance

        private string _article;
        private int _quantite;
        private bool _flag_quantite;
        private double _prixHT;
        private bool _flag_prixHT;

        #endregion

        #region constructeurs

        private void Initialiser()
        {
            this._article = null;
            this._quantite = 0;
            this._flag_quantite = false;
            this._prixHT = 0;
            this._flag_prixHT = false;
        }

        public ArtPanier()
        {
            this.Initialiser();
        }

        public ArtPanier(string article, string quantite, string prix)
        {
            this.Initialiser();
            this.article = article;
            this.strquantite = quantite;
            this.strprixHT = prix;
        }
        #endregion

        #region propriete et accesseurs
        public string article
        {
            get { return (this._article); }
            set { this._article = value; }
        }

        public int quantite
        {
            get { return (this._quantite); }
            set
            {
                this._quantite = value;
                this._flag_quantite = true;
            }
        }

        public string strquantite
        {
            get
            {
                string strquantite;
                if (this._flag_quantite == true)
                    strquantite = string.Format("{0:000}", quantite);
                else
                    strquantite = null;
                return strquantite;
            }

            set
            {
                int qt;
                bool ok;
                ok = int.TryParse(value, out qt);

                if (ok == true)
                {
                    quantite = qt;
                }

            }
        }

        public double prixHT
        {
            get { return (this._prixHT); }
            set
            {
                this._prixHT = value;
                this._flag_prixHT = true;
            }
        }

        public string strprixHT
        {
            get
            {
                string strprixHT;
                if (this._flag_prixHT == true)
                    strprixHT = string.Format("{0:0000.00}", prixHT);
                else
                    strprixHT = null;
                return strprixHT;
            }

            set
            {
                int pht;
                bool ok;
                ok = int.TryParse(value, out pht);

                if (ok == true)
                {
                    prixHT = pht;
                }

            }
        }
        #endregion

        #region méthode et propriétés de classe
        public static bool VerificationQuantite(int quantite, out int codeerreur)
        {
            bool ok;
            if (quantite < 0)
            {
                ok = false;
                codeerreur = 2;
            }
            else
            {
                ok = true;
                codeerreur = 0;
            }
            return ok;
        }


        public static bool VerificationQuantite(string quantite, out int codeerreur)
        {
            bool ok;
            int qt;

            ok = int.TryParse(quantite, out qt);


            if (ok == false)
            {
                ok = false;
                codeerreur = 3;
            }
            else
            {
                ok = VerificationQuantite(qt, out codeerreur);
            }
            return ok;
        }
        #endregion

        #region méthodes et propriétés virtuelles et abstraites

        public override string ToString()
        {
            string resultat;
            string article, prixHT, quantite;

            if (this._flag_quantite == true)
                quantite = this.strquantite;
            else
                quantite = null;

            article = this.article;
            prixHT = this.strprixHT;



            resultat = "Article : [" + article + "]: ";
            resultat += "Quantité [" + quantite + "]";
            resultat += "Prix HT [" + prixHT + "]";

            return resultat;
        }
        #endregion
    }
}

