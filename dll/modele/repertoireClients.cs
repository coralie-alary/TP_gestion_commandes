using Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class repertoireClients
    {
        #region attributs d'instance

        private string _nom;
        private List<Client> _list;

        #endregion

        #region constructeurs

        private void Initialiser()
        {
            this._nom = null;
            this._list = new List<Client>();

        }

        public repertoireClients()
        {
            this.Initialiser();
        }

        public repertoireClients(string nom)
        {
            this.Initialiser();
            this.nom = nom;
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

        public int nbcli
        {
            get
            {
                return this._list.Count();
            }
        }

        #endregion

        #region méthode et propriétés de classe

        public Particulier AjouterParticulier()
        {
            Particulier part;
            part = new Particulier();
            this._list.Add(part);

            return part;
        }

        public Particulier AjouterParticulier(string nom, string identifiant)
        {
            Particulier part;
            part = new Particulier(nom, identifiant);
            this._list.Add(part);

            return part;
        }


        public professionnel AjouterProfessionnel()
        {
            professionnel pro;
            pro = new professionnel();
            this._list.Add(pro);

            return pro;
        }

        public professionnel AjouterProfessionnel(string nom, string identifiant, string date)
        {
            professionnel pro;
            pro = new professionnel(nom, identifiant, date);
            this._list.Add(pro);

            return pro;
        }

        #endregion

        public void Supprimer()
        {
            //Il faut le preparer!!
        }

        public void Annuler()
        {
            //Il faut le preparer!!
        }

        public Client getClient(int id)
        {
            if ((id < 0) || (id >= this.nbcli))
                return null;
            return this._list[id];   
        }

        #region méthodes et propriétés virtuelles et abstraites

        public override string ToString()
        {
            string resultat;
            resultat = "";

            for (int i = 0; i < this.nbcli; i++)
            {
                resultat += this._list[i] + "\n";
            }

            return resultat;
        }

        #endregion

    }
}
