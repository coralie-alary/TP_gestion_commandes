using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Particulier : Client
    {

        #region constante
        private const double TVA = 19.6;
        #endregion

        #region constructeurs

        public Particulier() 
            : base()
        {
           
        }

        public Particulier(string nom, string identifiant)
            : base(nom, identifiant)
        {

        }
        #endregion

        #region redefinition des methodes virtuelles
        protected override double CalculTVA()
        {
            return TVA / 100 + 1;
        }
        #endregion

    }
}
