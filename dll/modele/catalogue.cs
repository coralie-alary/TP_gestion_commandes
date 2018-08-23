using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Catalogue
    {
        #region attributs d'instance

        private string _nom;
        private List<article> _list;

        #endregion

        #region constructeurs

        private void Initialiser()
        {
            this._nom = null;
            this._list = new List<article>();

        }

        public Catalogue()
        {
            this.Initialiser();
        }

        public Catalogue(string nom)
        {
            this.Initialiser();
            this.nom = nom;
        }

        public void Supprimer()
        {
            //Il faut le preparer!!
        }

        public void Annuler()
        {
            //Il faut le preparer!!
        }
        #endregion

        #region propriete et accesseurs
        public string nom
        {
            get { return (this._nom); }
            set
            {
                this._nom = value;
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

        public dvd AjouterDvd()
        {
            dvd d;
            d = new dvd();
            this._list.Add(d);

            return d;
        }

        public dvd AjouterDvd(string nom, string reference, string nomediteur, string prixHT, string duree)
        {
            dvd d;
            d = new dvd(nom, reference, nomediteur, prixHT, duree);
            this._list.Add(d);

            return d;
        }

        public ouvrage AjouterOuvrage()
        {
            ouvrage o;
            o = new ouvrage();
            this._list.Add(o);

            return o;
        }

        public ouvrage AjouterOuvrage(string nom, string reference, string nomediteur, string prixHT, string nomauteur)
        {
            ouvrage o;
            o = new ouvrage(nom, reference, nomediteur, prixHT, nomauteur);
            this._list.Add(o);

            return o;
        }
        #endregion

        #region méthodes et propriétés virtuelles et abstraites

        public override string ToString()
        {
            string resultat;
            resultat = "";

            for (int i = 0; i < this.Nb; i++)
            {
                resultat += this._list[i] + "\n";
            }

            return resultat;
        }
        #endregion

        public article getArticle(int id)
        {
            if ((id < 0) || (id >= this.Nb))
                return null;
            
            return this._list[id];
        }
    }
}
