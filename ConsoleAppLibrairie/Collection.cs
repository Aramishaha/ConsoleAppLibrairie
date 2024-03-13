
using System;
using System.Collections.Generic;
namespace ConsoleAppLibrairie
{/// <summary>
/// class Collection
/// </summary>
    class Collection 
    {
        /// <summary>
        /// liste d'objet de type collection
        /// </summary>

        private List<object> maCollection;
        
        /// <summary>
        /// Constructeur
        /// </summary>
        public Collection() 
        {
            
            maCollection = new List<object>();
        }
        /// <summary>
        /// Fonction qui ajoute un objet à notre liste de collection
        /// </summary>
        /// <param name="collection"></param>
        public void AjouterObject(Object unObjet )
        {
            maCollection.Add(unObjet);
        }

        /// <summary>
        /// Fonction qui supprime un objet de notre liste de collection à numindex
        /// </summary>
        /// <param name="numIndex"></param>
        public void SupprimerObjetIndex(int numIndex)
        {
            maCollection.RemoveAt(numIndex);
        }
        /// <summary>
        /// Renvoyer la collection d’objets
        /// </summary>
        /// <returns>maCollection</returns>
        public List<object> GetCollection()
        {
            return maCollection;
        }
        /// <summary>
        /// Renvoyer le nombre d’objet de la collection. 
        /// </summary>
        /// <returns>maCollection.Count</returns>
        public int Cardinal()
        {
            return maCollection.Count;
        }



    }

   
}
