using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class article
    {
        #region Attributes
        private string _nom;
        private string _reference;
        private string _nomediteur;
        private double _prixHT;
        private bool _flag_prix;
        #endregion

        #region Constructeur
        private void Initialiser()
        {
            this.nom = null;
            this.reference = null;
            this.nomediteur = null;
            this._flag_prix = false;
        }

        public article()
        {
            this.Initialiser();
        }

        public article(string nom, string reference, string nomediteur, string prix)
        {
            this.Initialiser();
            this.nom = nom;
            this.reference = reference;
            this.nomediteur = nomediteur;
            this.strprixHT = prix;
        }
        #endregion

        #region Property
        public string nom
        {
            set
            {
                this._nom = value;
            }
            get
            {
                return this._nom;
            }
        }

        public string reference
        {
            set
            {
                this._reference = value;
            }
            get
            {
                return this._reference;
            }
        }

        public string nomediteur
        {
            set
            {
                this._nomediteur = value;
            }
            get
            {
                return this._nomediteur;
            }
        }

        public double prixHT
        {
            set
            {
                this._prixHT = value;
                this._flag_prix = true;
            }
            get
            {
                return this._prixHT;
            }
        }

        public string strprixHT
        {
            set
            {
                double prix;
                bool ok;
                string filtre;

                filtre = value.Replace('.', ',');
                ok = double.TryParse(filtre, out prix);
                if (ok == true)
                    this.prixHT = prix;
            }
            get
            {
                string prix;
                if(this._flag_prix == true)
                    prix = string.Format("{0:0.00}", this.prixHT);
                else
                    prix = null;

                return prix;
            }
        }
        #endregion

        #region Verification
        public static bool VerificationNom(string nom, out int codeerreur)
        {
            bool ok;

            if(string.IsNullOrEmpty(nom) == true)
            {
                ok = false;
                codeerreur = 4;
            }
            else
            {
                ok = true;
                codeerreur = 0;
            }

            return ok;
        }

        public static bool VerificationReference(string reference, out int codeerreur)
        {
            bool ok;

            if (string.IsNullOrEmpty(reference) == true)
            {
                ok = false;
                codeerreur = 5;
            }
            else
            {
                ok = true;
                codeerreur = 0;
            }

            return ok;
        }

        public static bool VerificationNomEditeur(string nomediteur, out int codeerreur)
        {
            bool ok;

            if (string.IsNullOrEmpty(nomediteur) == true)
            {
                ok = false;
                codeerreur = 6;
            }
            else
            {
                ok = true;
                codeerreur = 0;
            }

            return ok;
        }

        public static bool VerificationPrixHT(double prix, out int codeerreur)
        {
            bool ok;

            if(prix < 0)
            {
                ok = false;
                codeerreur = 7;
            }
            else
            {
                ok = true;
                codeerreur = 0;
            }

            return ok;
        }

        public static bool VerificationPrixHT(string strprix, out int codeerreur)
        {
            bool ok;
            double prix;

            ok = double.TryParse(strprix, out prix);
            if (ok == true)
                ok = VerificationPrixHT(prix, out codeerreur);
            else
                codeerreur = 8;

            return ok;
        }
        #endregion

        protected virtual string Tete
        {
            get
            {
                return "Article";
            }
        }

        protected virtual string Caracteristique
        {
            get
            {
                return "";
            }
        }

        public override string ToString()
        {
            string resultat;
            string reference, prixHT;

            reference = this.reference;
            if (this._flag_prix == true)
                prixHT = this.strprixHT;
            else
                prixHT = null;

            resultat = "<" + this.Tete + ">";
            resultat += "Ref: [" + reference + "]: ";
            resultat += "Prix HT: [" + prixHT + "]";

            return resultat;
        }
    }
}
