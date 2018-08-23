using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class dvd : article
    {
        #region Attributes
        private int _duree;
        private bool _flag_duree;
        #endregion

        #region Constructeur
        private void Initialiser()
        {
            this._flag_duree = false;
        }

        //dvd classe mère => article
        public dvd() : base ()
        {
            this.Initialiser();
        }

        //constructeur surchargé
        public dvd(string nom, string reference, string nomediteur, string prixHT, string duree) : base(nom, reference, nomediteur, prixHT)
        {
            this.Initialiser();
            this.strduree = duree;
        }
        #endregion

        #region Property
        public int duree
        {
            set
            {
                this._duree = value;
                this._flag_duree = true;
            }
            get
            {
                return this._duree;
            }
        }

        public string strduree
        {
            set
            {
                bool ok;
                int duree;

                ok = int.TryParse(value, out duree);
                if (ok == true)
                    this.duree = duree;
            }
            get
            {
                string strduree;

                if (this._flag_duree == true)
                    strduree = string.Format("{0:000}", this.duree);
                else
                    strduree = null;

                return strduree;
            }
        }
        #endregion

        #region Verification
        public static bool VerificationDuree(int duree, out int codeerreur)
        {
            bool ok;

            if(duree < 0)
            {
                ok = false;
                codeerreur = 10;
            }
            else
            {
                ok = true;
                codeerreur = 0;
            }

            return ok;
        }

        public static bool VerificationDuree(string strduree, out int codeerreur)
        {
            bool ok;
            int duree;

            ok = int.TryParse(strduree, out duree);
            if (ok == true)
                ok = VerificationDuree(duree, out codeerreur);
            else
                codeerreur = 11;

            return ok;
        }
        #endregion

       // protected override string Tete
      //  {
         //   get
         //   {
          //      return "DVD";
          //  }
      //  }

      //  protected override string Caracteristique
       // {
        //    get
        //    {
          //      return this.strduree;
          //  }
       // }
    }
}
