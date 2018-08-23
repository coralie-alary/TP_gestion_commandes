using System;

namespace Modele
{
    public class professionnel : Client
    {
        //Date
        //string strx = DateTime.Now.ToString("dddd d/M/yyyy");
        private DateTime validationdate = DateTime.Now.AddYears(-2);

        #region attributs d'instance
        private DateTime _date;
        private bool _flag_date;
        #endregion

        #region constante
        private const double TVA = 19.6;
        private const double TVARED = 5.5;
        #endregion


        #region constructeurs

        private void Initialiser()
        {
            this._flag_date = false;
        }

        public professionnel()
            : base()
        {
            this.Initialiser();
        }

        public professionnel(string nom, string identifiant, string date)
            : base(nom, identifiant)
        {
            this.Initialiser();
            this.strdate = date;
        }

        public DateTime date
        {
            set
            {
                this._date = value;
                this._flag_date = true;
            }
            get
            {
                return this._date;
            }
        }

        public string strdate
        {
            set
            {
                //DateTime date;
                //bool ok;

                this.date = Convert.ToDateTime(value).Date;
                /*ok = DateTime.TryParse(value, out date);
                if (ok == true)
                    this.date = date;*/
            }
            get
            {
                string strdate;

                if (this._flag_date == true)
                    strdate = this.date.ToString("dddd d/M/yyyy");
                else
                    strdate = null;

                return strdate;
            }
        }

        #endregion


        #region redefinition des methodes virtuelles
        protected override double CalculTVA()
        {
            double resultat;

            if (this.date > validationdate)
                resultat = TVARED;
            else
                resultat = TVA;

            return resultat / 100 + 1;
        }
        #endregion

    }
}
