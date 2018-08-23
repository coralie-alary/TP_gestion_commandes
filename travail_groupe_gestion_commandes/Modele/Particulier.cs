using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace travail_groupe_gestion_commandes.Modele
{
    public class Particulier : Client
    {
        #region attributs d'instance

        private double _TVA;

        #endregion

        #region proprietes et accesseurs

        public double TVA
        {
            get { return (this._TVA); }
            set { this._TVA = value; }
        }
        #endregion

        #region constructeurs
        private void Initialiser()
        {
            this.TVA = null;
        }

        public Particulier() 
            : base()
        {
            this.Initialiser();
        }

        #endregion

        #region redefinition des methodes virtuelles

        protected override string entete
        {
            get { return ("<PARTICULIER>"); }
        }

        protected override string caracteristiques
        {

        }

        public override bool CalculTVA()
        {

        }
        #endregion

        #region methode de classe
        // methode de verification
        #endregion
    }
}
