using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public class MesMethodes
    {
        //par convention, les classes et méthodes et interface débutent par une majuscule. (PascalCase) (tandis que le camelCase commence par une minuscule, on l'utilise pour les variables)
        // visibilité [static] Type-Retour (ou void) puis le nom de la méthode(paramètres éventuels){instructions}

        //une classe données peut posséder deux types de méthodes : 
        // Une méthode d'instance : accessible via une instance de la classe en question - instancier une classe : générer un objet de la classe
        //une méthode de classe : une méthode static - pas besoin d'instancier la classe pour avoir accès à ces méthodes.
        /// <summary>
        /// Méthode qui calcule la somme de 2 entiers
        /// </summary>
        /// <param name="x">premier entier</param>
        /// <param name="y">deuxième entier</param>
        /// <returns>retourne un entier</returns>
        public static int Somme(int x, int y)
        {
            return x+y;
        }

        //Surcharge d'une méthode : pouvoir définir la même méthode dans la même classe avec seulement les paramètres qui changent.
        /// <summary>
        /// Méthode qui calcule la somme de trois entiers
        /// </summary>
        /// <param name="x">premier entier</param>
        /// <param name="y">deuxième entier</param>
        /// <param name="z">troisième entier</param>
        /// <returns>retourne un entier</returns>
        public static int Somme(int x,int y,int z)// ici la même méthode avec 3 paramètres.
        {
            return x + y + z;
        }

        public static void Afficher(string chaine)
        {
            Console.WriteLine(chaine);
        }

        // definir une méthode qui liste le contenu d'un tableau d'entiers
        public static void Afficher(int[] tableau)
        {
            foreach(int item in tableau)
            {
                Console.WriteLine(item);
            }
        }

        //une méthode qui renvoie la somme des éléments d'un tableau d'entiers
        public static int Somme(int[] tab)
        {
            return tab.Sum();
        }
        //Une méthode qui renvoie la moyenne des éléments d'un tableau d'entiers

        public static double Mean(int[] tab)
        {
            return (double)tab.Average();
        }
        //Une méthode qui renvoie l'élément le plus petit d'un tableau d'entiers
        public static int Min(int[] tab)
        {
            return tab.Min();
        }
    }
}
