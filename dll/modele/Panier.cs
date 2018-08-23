
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Panier
    {
        #region attributs d'instance

        private int _numero_commande;
        private bool _flag_numero_commande;
        private string _client;
        private List<ArtPanier> _list;

        #endregion

        #region constructeurs

        private void Initialiser()
        {
            this._flag_numero_commande= false;
            this._client = null;
            this._list = new List<ArtPanier>();
     
        }

        public Panier()
        {
            this.Initialiser();
        }

        public Panier(int numero_commande, string client)
        {
            this.Initialiser();
            this.numero_commande = numero_commande;
            this.client = client;
    
        }
        #endregion

        #region propriete et accesseurs

        public int numero_commande
        {
            get { return (this._numero_commande); }
            set
            {
                this._numero_commande = value;
                this._flag_numero_commande = true;
            }
        }


        public string strnumero_commande
        {
            get
            {
                string strnumero_commande;
                if (this._flag_numero_commande == true)
                    strnumero_commande = string.Format("{0000}", numero_commande);
                else
                    strnumero_commande = null;
                return strnumero_commande;
            }

            set
            {
                int ncom;
                bool ok;
                ok = int.TryParse(value, out ncom);

                if (ok == true)
                {
                    numero_commande = ncom;
                }

            }
        }
        public string client
        {
            get { return (this._client); }
            set
            {
                this._client = value;
            }
        }

        public int Nb
        {
            get
            {
                return this._list.Count();
            }
        }

        #endregion

        #region méthode et propriétés de classe

        //public static AjouterArticle()
        //{

        // }
        //******************************
        // public static AjouterArticle()
        // {

        //  }
        #endregion

        #region méthodes et propriétés virtuelles et abstraites

        public override string ToString()
        {
            string resultat;
            resultat = "";

            for (int i = 0; i < this.Nb; i++)
            {
                resultat += this._list[i]+"\n";
            }
            
            return resultat;
        }
        #endregion
    }
}

