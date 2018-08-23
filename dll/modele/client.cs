using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public abstract class Client
    {
      
        #region attributs d'instance

        private string _nom;
        private int _identifiant;
        private bool _flag_identifiant;

        #endregion

        #region constructeurs

        private void Initialiser()
        {
            this._nom = null;
            this._flag_identifiant = false;
        }


        public Client()
        {
            this.Initialiser();
        }

        public Client(string nom, string identifiant)
        {
            this.Initialiser();
            this.nom = nom;
            this.stridentifiant = identifiant;
        }

        #endregion

        #region propriete et accesseurs

        // accesseurs pour le nom
        public string nom
        {
            get { return (this._nom); }
            set { this._nom = value; }
        }

        public int identifiant
        {
            get { return (this._identifiant); }
            set
            {
                this._identifiant = value;
                this._flag_identifiant = true;
            }
        }

        public string stridentifiant
        {
            get {
                string stridentifiant;
                if (this._flag_identifiant == true)
                    stridentifiant = string.Format("{0:0000}", identifiant);
                else
                    stridentifiant = null;
                return stridentifiant;     
                 }

            set
            {
                int id;
                bool ok;
                ok = int.TryParse(value, out id);

                if(ok == true)
                {
                    identifiant = id;
                }

            }
        }


        #endregion

        #region méthode et propriétés de classe

        public static bool VerificationNom(string nom, out int codeerreur)
        {
            bool ok; 
            if (string.IsNullOrEmpty(nom) == true)
            {
                ok = false;
                codeerreur = 1;
            }
            else
            {
                ok = true;
                codeerreur = 0;
            }
            return ok;
        }

        protected abstract double CalculTVA();

        #endregion

        #region méthodes et propriétés virtuelles et abstraites

        public override string ToString()
        {
            string resultat;
            string identifiant, nom;

            if (this._flag_identifiant == true)
                identifiant = this.stridentifiant;
            else
                identifiant = null;
            nom = this.nom;


            resultat = "id : [" + identifiant + "]: ";
            resultat += "Nom : [" + nom + "]";

            return resultat;
        }
        #endregion

    }
}
