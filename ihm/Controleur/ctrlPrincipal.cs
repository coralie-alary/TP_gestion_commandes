using ihm.Vues;
using Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ihm.Controleur
{
    public class ctrlPrincipal
    {
        private ctrlVues _cv;
        private Catalogue _ca_tous, _ca_dvd, _ca_ouvrage, _ca_moins, _ca_plus;
        private repertoireClients _cl;

        private void Initialiser()
        {
            AgregationArticles();
            AgregationClients();

            this._cv.AfficherNomCatalogues(this._ca_tous.nom);
            this._cv.AfficherNomCatalogues(this._ca_dvd.nom);
            this._cv.AfficherNomCatalogues(this._ca_ouvrage.nom);
            this._cv.AfficherNomCatalogues(this._ca_moins.nom);
            this._cv.AfficherNomCatalogues(this._ca_plus.nom);

            for (int i=0; i<this._cl.nbcli; i++)
            {
                this._cv.AfficherClients(this._cl.getClient(i));
            }

            this._cv.NombreClients(this._cl.nbcli);

            //AffichageCatalogues();
        }

        public ctrlPrincipal()
        {
            _cv = new ctrlVues(this);

            this._ca_tous = new Catalogue("TOUS");
            this._ca_dvd = new Catalogue("LES DVD");
            this._ca_ouvrage = new Catalogue("LES OUVRAGES");
            this._ca_moins = new Catalogue("LES MOINS CHERS");
            this._ca_plus = new Catalogue("LES PLUS CHERS");

            this._cl = new repertoireClients();

            this.Initialiser();
        }

        public bool encours
        {
            get
            {
                return this._cv.encours;
            }
        }

        #region CATALOGUE
        //Creation catalogues articles
        public void AgregationArticles()
        {
            AgregationDvd("DVD_0", "D0", "AFPAMOVIE", "12.34", "120");
            AgregationDvd("DVD_1", "D1", "AFPAMOVIE", "22.34", "220");
            AgregationDvd("DVD_2", "D2", "AFPAMOVIE", "32.34", "130");
            AgregationDvd("DVD_3", "D3", "AFPAMOVIE", "42.34", "140");
            AgregationDvd("DVD_4", "D4", "AFPAMOVIE", "52.34", "150");
            AgregationDvd("DVD_5", "D5", "AFPAMOVIE", "62.34", "160");
            AgregationDvd("DVD_6", "D6", "AFPAMOVIE", "72.34", "170");
            AgregationDvd("DVD_7", "D7", "AFPAMOVIE", "82.34", "180");
            AgregationDvd("DVD_8", "D8", "AFPAMOVIE", "92.34", "190");
            AgregationDvd("DVD_9", "D9", "AFPAMOVIE", "102.34", "20");

            AgregationOuvrage("OUV_0", "O0", "AFPAPRESS", "9.09", "Auteur_0");
            AgregationOuvrage("OUV_1", "O1", "AFPAPRESS", "19.09", "Auteur_1");
            AgregationOuvrage("OUV_2", "O2", "AFPAPRESS", "29.09", "Auteur_2");
            AgregationOuvrage("OUV_3", "O3", "AFPAPRESS", "39.09", "Auteur_3");
            AgregationOuvrage("OUV_4", "O4", "AFPAPRESS", "49.09", "Auteur_4");
            AgregationOuvrage("OUV_5", "O5", "AFPAPRESS", "59.09", "Auteur_5");
            AgregationOuvrage("OUV_6", "O6", "AFPAPRESS", "69.09", "Auteur_6");
            AgregationOuvrage("OUV_7", "O7", "AFPAPRESS", "79.09", "Auteur_7");
            AgregationOuvrage("OUV_8", "O8", "AFPAPRESS", "89.09", "Auteur_8");
            AgregationOuvrage("OUV_9", "O9", "AFPAPRESS", "99.09", "Auteur_9");

        }

        //+DVD
        public void AgregationDvd(string nom, string reference, string nomediteur, string prixHT, string duree)
        {
            double prix;
            string filtre;

            filtre = prixHT.Replace('.', ',');
            double.TryParse(filtre, out prix);

            this._ca_tous.AjouterDvd(nom, reference, nomediteur, prixHT, duree);
            this._ca_dvd.AjouterDvd(nom, reference, nomediteur, prixHT, duree);
            if (prix < 35)
                this._ca_moins.AjouterDvd(nom, reference, nomediteur, prixHT, duree);
            else
                this._ca_plus.AjouterDvd(nom, reference, nomediteur, prixHT, duree);
        }

        //+OUVRAGE
        public void AgregationOuvrage(string nom, string reference, string nomediteur, string prixHT, string nomauteur)
        {
            double prix;
            string filtre;

            filtre = prixHT.Replace('.', ',');
            double.TryParse(filtre, out prix);

            this._ca_tous.AjouterOuvrage(nom, reference, nomediteur, prixHT, nomauteur);
            this._ca_ouvrage.AjouterOuvrage(nom, reference, nomediteur, prixHT, nomauteur);
            if (prix < 35)
                this._ca_moins.AjouterOuvrage(nom, reference, nomediteur, prixHT, nomauteur);
            else
                this._ca_plus.AjouterOuvrage(nom, reference, nomediteur, prixHT, nomauteur);
        }

        //AFFICHAGE DES CATALOGUES
        public void AffichageCatalogues(string selection)
        {
            Catalogue cat;

            this._cv.ClearListCatalogues();
            switch (selection)
            {
                case "TOUS":
                    cat = this._ca_tous;
                    break;
                case "LES DVD":
                    cat = this._ca_dvd;
                    break;
                case "LES OUVRAGES":
                    cat = this._ca_ouvrage;
                    break;
                case "LES MOINS CHERS":
                    cat = this._ca_moins;
                    break;
                case "LES PLUS CHERS":
                    cat = this._ca_plus;
                    break;
                default:
                    cat = null;
                    break;
            }
            this._cv.ValeurFinanciere(CalculVF(cat));
            this._cv.NombreArticles(cat.Nb);
            for (int i = 0; i < cat.Nb; i++)
            {
                this._cv.AffichageCatalogues(cat.getArticle(i));
            }
        }

        //CALCUL VALEUR FINANCIERE
        private double CalculVF(Catalogue cat)
        {
            double resultat, prix;
            article art;

            resultat = 0;
            for (int i = 0; i < cat.Nb; i++)
            {
                art = cat.getArticle(i);
                prix = art.prixHT;
                resultat += prix;
            }

            return resultat;
        }
        #endregion


        #region CLIENTS

        //Creation collectionneur Clients
        public void AgregationClients()
        {
            this.AgrePar("Par1", "1001");
            this.AgrePar("Par2", "1002");
            this.AgrePar("Par3", "1003");
            this.AgrePar("Par4", "1004");
            this.AgrePar("Par5", "1005");

            this.AgrePro("Pro1", "2001", "10/12/2018");
            this.AgrePro("Pro2", "2002", "10/12/2014");
            this.AgrePro("Pro3", "2003", "10/01/2016");
            this.AgrePro("Pro4", "2004", "10/12/2018");
            this.AgrePro("Pro5", "2005", "10/12/2015");

        }

        //+PARTICULIER
        public void AgrePar(string nom, string identifiant)
        {
            this._cl.AjouterParticulier(nom, identifiant);
        }

        //+PROFESSIONNEL
        public void AgrePro(string nom, string identifiant, string date)
        {
            this._cl.AjouterProfessionnel(nom, identifiant, date);
        }

        public void Annuler()
        {
            //this._ca.Annuler(); 
        }

            #endregion

            #region PANIER

        public void Vider()
        {
            //Supprimer toutes le contenu du panier

            //this._ca.Supprimer();//ca -> catalogue
        }

        public void Supprimer()
        {
            //this._ca.Supprimer();//supprimer JUSTE UNE LIGNE ARTICLE
        }

       
        public void AffichageClient(int choix)
        {
      
            Client cli;
            cli = this._cl.getClient(choix);
            this._cv.AffichageNomClient(cli.nom);
            this._cv.AffichageIdentifiantClient(cli.stridentifiant);
        }

        #endregion



    }
}
