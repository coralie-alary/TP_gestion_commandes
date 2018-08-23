using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele;


namespace testermodele
{
    class test
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" FICHIER DE TEST ");

            Particulier p1;

            p1 = new Particulier();

            p1.nom = "toto";
            p1.identifiant = 1234;

            Console.WriteLine(p1);


            professionnel pro1;

            pro1 = new professionnel();

            pro1.nom = "Pro du PC";  // on utilise le SET, on définit quelque chose à droite du =
            pro1.identifiant = 5678; 

            Console.WriteLine(pro1);

            ArtPanier panier1;
            panier1 = new ArtPanier("dvd", "3", "50");
            Console.WriteLine(panier1);

        }
    }
}
