using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLibrairie
{
    class Program
    {
        static void Main(string[] args)
        {
            Librairie uneLibrairie = new Librairie("Le bonheur", 255, "labonneadresse", "Paris", "librairiemail", 07582828);
            Livre premierLivre = new Livre(1, "L'appel de Cthulhu", "H.P Lovecraft", 5.45m,12) ;
            Livre secondLivre = new Livre(2, "Le seigneur des Anneaux", "J.R.R. Tolkien", 15.90m, 8);
            uneLibrairie.AjouterLivre(premierLivre);
            uneLibrairie.AjouterLivre(secondLivre);



            int option = 100;
            ; while (option != 9)
            {
                Console.WriteLine("-------------------------------------------\n");
                Console.WriteLine(" Menu\n ");
                Console.WriteLine(" Taper 1 pour si vous voulez rechercher un livre : \n" + " Taper 2 pour si vous voulez ajouter un nouveau livre dans la librairie: \n" + " Taper 3 pour si vous voulez supprimer un livre de la librairie : \n" + " Taper 4 pour si vous voulez modifier un livre. : \n" + " Taper 5 pour si vous voulez approvisionner le stock d’un livre: \n" + " Taper 6 si vous voulez vendre un nombre d’exemplaires d’un livre : \n" + " Taper 7 pour afficher tous les livres: \n " + "Taper 8 pour afficher le livre le moins cher \n" + " Taper 9 pour quittez :");
                Console.WriteLine("-------------------------------------------\n");
                option = Convert.ToInt32(Console.ReadLine());


                if (option == 1)
                {
                    Console.WriteLine("Saisissez le numéro du livre à afficher : ");
                    int unNumLivre = int.Parse(Console.ReadLine());

                    Livre ceLivre = uneLibrairie.RechercheLivre(unNumLivre);

                    if (ceLivre != null)
                    {
                        ceLivre.Afficher();


                    }
                    else
                    {
                        Console.WriteLine("Ce numéro n'existe pas");
                    }
                }
                if (option == 7)
                {
                    Console.WriteLine("Voici tous les livres de la librairie : ");
                    uneLibrairie.AfficherLivres();

                   
                }
                if (option == 8)
                {
                    Console.WriteLine("Voici le livre le moins cher de la librairie : ");
                    Livre livreLeMoinsCher = null;
                    livreLeMoinsCher = uneLibrairie.MoinsCher();
                    livreLeMoinsCher.Afficher();


                }



                if (option == 2)

                {
                    Console.WriteLine(" Saisissez les données du nouveau livre que vous voulez ajouter : ");
                    Console.WriteLine("Saisissez le numéro du livre : ");
                    int unNumLivre = int.Parse(Console.ReadLine());
                    Console.WriteLine("Saisissez le titre du livre : ");
                    string unTitreLivre = (Console.ReadLine());
                    Console.WriteLine("Saisissez qui est l'auteur du livre : ");
                    string unAuteurLivre = (Console.ReadLine());
                    Console.WriteLine("Saisissez qui est le prix du livre : ");
                    decimal unPrixLivre = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Saisissez le nombre de livre en stock : ");
                    int unStockLivre = int.Parse(Console.ReadLine());
                    Livre l3 = new Livre(unNumLivre, unTitreLivre, unAuteurLivre, unPrixLivre, unStockLivre);
                    uneLibrairie.AjouterLivre(l3);
                }

                else if (option == 5)
                {

                    Console.WriteLine("Saisissez le numéro du livre à approvisionner : ");
                    int unNumLivre = int.Parse(Console.ReadLine());

                    Livre ceLivre = uneLibrairie.RechercheLivre(unNumLivre);

                    if (ceLivre != null)
                    {
                        Console.WriteLine("Saisissez le montant à créditer : ");
                        int leStockAjoute = int.Parse(Console.ReadLine());
                        ceLivre.Approvisionnement(leStockAjoute);
                    }
                    else
                    {
                        Console.WriteLine("Ce numéro n'existe pas");
                    }
                }

                else if (option == 6)
                {
                    Console.WriteLine("Saisissez le numéro du livre à vendre : ");
                    int unNumLivre = int.Parse(Console.ReadLine());

                    Livre ceLivre = uneLibrairie.RechercheLivre(unNumLivre);

                    if (ceLivre != null)
                    {
                        Console.WriteLine("Saisissez le nombre de livres à vendre : ");
                        int leStockVendu = int.Parse(Console.ReadLine());
                        ceLivre.Vendre(leStockVendu);
                    }
                    else
                    {
                        Console.WriteLine("Ce numéro n'existe pas");
                    }

                }

                else if (option == 4)
                {
                    Console.WriteLine("Saisissez le numéro de compte à modifier : ");
                    int unNumLivre = int.Parse(Console.ReadLine());

                    Livre ceLivre = uneLibrairie.RechercheLivre(unNumLivre);

                    if (ceLivre != null)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine(" Numéro livre: " + ceLivre.GetNumLivre());
                        Console.WriteLine(" Titre du livre : " + ceLivre.GetTitreLivre());
                        Console.WriteLine(" Auteur du livre : " + ceLivre.GetAuteurLivre());
                        Console.WriteLine(" Prix du livre : " + ceLivre.GetPrixLivre());
                        Console.WriteLine(" Nombre de livres en stock : " + ceLivre.GetStockLivre());
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("Ce numéro n'existe pas");
                    }
                }
                else if (option == 3)
                {
                    Console.WriteLine("Saisissez le numéro du livre à afficher : ");
                    int unNumLivre = int.Parse(Console.ReadLine());

                    Livre ceLivre = uneLibrairie.RechercheLivre(unNumLivre);

                    if (ceLivre != null)
                    {
                        Console.WriteLine("Saisissez le numéro de compte à supprimer : ");
                        int leMontant = int.Parse(Console.ReadLine());
                        uneLibrairie.SupprimerLivre(unNumLivre);
                    }
                    else
                    {
                        Console.WriteLine("Ce numéro n'existe pas");
                    }





                }
            }
        }
    }
}


