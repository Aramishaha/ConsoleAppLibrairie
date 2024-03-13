using System;
using System.Collections.Generic;
namespace ConsoleAppLibrairie
{
    class Librairie 
    {
        private string nomLibrairie;
        private int adresseNumRue;
        private string adresseCodePostal;
        private string adresseVille;
        private string mail;
        private int telephone;
        private Collection lesLivres;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="unNomLibrairie"></param>
        /// <param name="uneAdresseNumRue"></param>
        /// <param name="uneAdresseCodePostal"></param>
        /// <param name="uneAdresseVille"></param>
        /// <param name="unMail"></param>
        /// <param name="unTelephone"></param>
        public Librairie(string unNomLibrairie, int uneAdresseNumRue, string uneAdresseCodePostal, string uneAdresseVille, string unMail, int unTelephone) 
        {
            nomLibrairie = unNomLibrairie;
            adresseNumRue = uneAdresseNumRue;
            adresseCodePostal = uneAdresseCodePostal;
            adresseVille = uneAdresseVille;
            mail = unMail;
            telephone = unTelephone;

            lesLivres = new Collection();
        }
        /// <summary>
        /// Ajout d'un livre la collection
        /// </summary>
        /// <param name="unLivre"></param>
        public void AjouterLivre(Livre unLivre) 
        {
            lesLivres.AjouterObject(unLivre);

        }
        /// <summary>
        /// Suppression d'un livre de la collection
        /// </summary>
        /// <param name="numIndex"></param>
        public void SupprimerLivre(int numIndex) 
        {
            lesLivres.SupprimerObjetIndex(numIndex);
        }
        /// <summary>
        /// Retourne les livres de la collection
        /// </summary>
        /// <returns>Les livres</returns>
        public Collection GetLivres() 
        {
            return lesLivres;
        } 
        /// <summary>
        /// Affiche les informations de la librairie
        /// </summary>
        public void AfficherLibrairie() 
        {
            Console.WriteLine("-----------------------------------------------------------\n");
            Console.WriteLine("Les informations de la librairie sont : {0}", nomLibrairie);
            Console.WriteLine("Les informations de la librairie sont : {0}", adresseNumRue);
            Console.WriteLine("Les informations de la librairie sont : {0}", adresseCodePostal);
            Console.WriteLine("Les informations de la librairie sont : {0}", adresseVille);
            Console.WriteLine("Les informations de la librairie sont : {0}", mail);
            Console.WriteLine("Les informations de la librairie sont : {0}", telephone);
            Console.WriteLine("-----------------------------------------------------------\n");
        }
        /// <summary>
        /// Affiche tous les livres dans la collection
        /// </summary>
        public void AfficherLivres() 
        {

            foreach (Livre unlivre in lesLivres.GetCollection())
            {
                Console.WriteLine("-------------------------------------------\n");
                Console.WriteLine("Voici tous les livres dans la collection\n");
                Console.WriteLine(unlivre.GetNumLivre());
                Console.WriteLine(unlivre.GetTitreLivre());
                Console.WriteLine(unlivre.GetAuteurLivre());
                Console.WriteLine(unlivre.GetPrixLivre());
                Console.WriteLine(unlivre.GetPrixLivre());
                Console.WriteLine("-------------------------------------------\n");
            }

           
        }
        /// <summary>
        /// Affiche le livre le moins cher
        /// </summary>
        /// <returns>resultat</returns>
        public Livre MoinsCher() 
        {
            decimal prixMin = 1000000000000000;
            Livre resultat = null;

            foreach(Livre unLivre in lesLivres.GetCollection()) 
            {
                if (unLivre.GetPrixLivre() < prixMin) 
                {
                    prixMin = unLivre.GetPrixLivre();
                    resultat = unLivre;
                }
            }
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine("Voici le livre le moins cher : \n");
            return resultat;
        }
        public Livre RechercheLivre(int numero)
        {
            foreach (Livre unLivre in lesLivres.GetCollection())
            {
                if (unLivre.GetNumLivre() == numero)
                {
                    return unLivre;
                }

            }

            return null;

        }



    }




}
    

