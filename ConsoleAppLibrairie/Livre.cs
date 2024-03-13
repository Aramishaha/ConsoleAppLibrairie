using System;
using System.Collections.Generic;
namespace ConsoleAppLibrairie
{
    class Livre 
    {
        
        private int numLivre;
       
        private string titreLivre;
        
        private string auteurLivre;
        
        private decimal prixLivre;
        
        private int stockLivre;
    
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="unNumLivre"></param>
        /// <param name="unTitreLivre"></param>
        /// <param name="unAuteurLivre"></param>
        /// <param name="unPrixLivre"></param>
        /// <param name="unStockLivre"></param>
        public Livre(int unNumLivre, string unTitreLivre, string unAuteurLivre, decimal unPrixLivre, int unStockLivre) 
        {
            numLivre = unNumLivre;
            titreLivre = unTitreLivre;
            auteurLivre = unAuteurLivre;
            prixLivre = unPrixLivre;
            stockLivre = unStockLivre;


        }
        /// <summary>
        /// Recherche un livre par son numéro
        /// </summary>
        /// <returns>numLivre</returns>
        public int GetNumLivre() 
        {
            return numLivre;
        }
        /// <summary>
        /// Met à jour le numéro d'un livre
        /// </summary>
        /// <param name="unNumeroLivre"></param>
        public void SetNumLivre(int unNumeroLivre) 
        {
            this.numLivre = unNumeroLivre;
        }
        /// <summary>
        /// Recherche un livre par son nom
        /// </summary>
        /// <returns>titreLivre</returns>
        public string GetTitreLivre() 
        {
            return titreLivre;
        }
        /// <summary>
        /// Recherche un livre par son auteur
        /// </summary>
        /// <returns>auteurLivre</returns>
        public string GetAuteurLivre()
        {
            return auteurLivre;
        }
        /// <summary>
        /// Met à jour le nom d'un auteur pour un livre
        /// </summary>
        /// <param name="unAuteurLivre"></param>
        public void SetAuteurLivre(string unAuteurLivre)
        {
            this.auteurLivre = unAuteurLivre;
        }
        /// <summary>
        /// Retourne le prix d'un livre
        /// </summary>
        /// <returns>prixLivre</returns>
        public decimal GetPrixLivre() 
        {
            return prixLivre;
        }
        /// <summary>
        /// met à jour le prix d'un livre
        /// </summary>
        /// <param name="unPrixLivre"></param>
        public void SetPrixLivre(decimal unPrixLivre)
        {
            this.prixLivre = unPrixLivre;
        }
        /// <summary>
        /// Ajoute un stock de livre au stock existant
        /// </summary>
        /// <param name="unStockAjout"></param>
        public void Approvisionnement(int unStockAjout) 
        {
            stockLivre = stockLivre + unStockAjout;
        }
        public int GetStockLivre()
        {
            return stockLivre;
        }

        /// <summary>
        /// Met à jour le stock de livre
        /// </summary>
        /// <param name="unStockVendu"></param>
        public void Vendre(int unStockVendu)
        {
            stockLivre = stockLivre - unStockVendu;
        }
        /// <summary>
        /// Affiche les informations d'un livre
        /// </summary>
        public void Afficher()
        {
            Console.WriteLine("Le numéro du livre est : {0}",numLivre);
            Console.WriteLine("Le titre du livre est : {0}", titreLivre);
            Console.WriteLine("L'auteur du livre est : {0}", auteurLivre);
            Console.WriteLine("Le prix du livre est : {0}", prixLivre);
            Console.WriteLine("Le nombre de livres diponibles en stock est : {0}", stockLivre);
        }


    }

}
