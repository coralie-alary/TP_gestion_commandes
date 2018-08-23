using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travail_groupe_gestion_commandes.Modele
{
    public abstract class Client
    {
        #region constantes
        #endregion

        #region attributs de classe
        #endregion

        #region attributs d'instance

        private string _nom;
        private string _identifiant;

        #endregion

        #region propriete et accesseurs

        // accesseurs pour le nom
        public string nom
        {
            get { return (this._nom); }
            set { this._nom = value; }
        }

        #endregion

        #region constructeurs

        private void Initialiser()
        {
            this._nom = null;
            this._identifiant = null;
        }

        public Client()
        {
            this.Initialiser();
        }

        #endregion

        #region méthodes et propriétés virtuelles et abstraites

        protected virtual string entete
        {
            get { return ("<CLIENT>"); }
        }

        //public abstract bool CalculTVA();

        #endregion

        #region redefinition des méthodes virtuelles
        //public override string ToString()
        //{
       // }
            #endregion

        #region méthode et propriétés de classe
           
        // methode VerificationNom
        #endregion


        }
}
