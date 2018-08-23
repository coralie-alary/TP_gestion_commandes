using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class ouvrage : article
    {
        #region Attributes
        private string _nomauteur;
        #endregion

        #region Constructeur
        private void Initialiser()
        {
            this.nomauteur = null;
        }

        public ouvrage() : base()
        {
            this.Initialiser();
        }

        public ouvrage(string nom, string reference, string nomediteur, string prixHT, string nomauteur) : base(nom, reference, nomediteur,prixHT)
        {
            this.Initialiser();
            this.nomauteur = nomauteur;
        }
        #endregion

        #region Property
        public string nomauteur
        {
            set
            {
                this._nomauteur = value;
            }
            get
            {
                return this._nomauteur;
            }
        }
        #endregion

        #region Verification
        public static bool VerificationNomAuteur(string nomauteur, out int codeerreur)
        {
            bool ok;

            if (string.IsNullOrEmpty(nomauteur) == true)
            {
                ok = false;
                codeerreur = 9;
            }
            else
            {
                ok = true;
                codeerreur = 0;
            }

            return ok;
        }
        #endregion

        protected override string Tete
        {
            get
            {
                return "OUV";
            }
        }

        protected override string Caracteristique
        {
            get
            {
                return this.nomauteur;
            }
        }
    }
}
