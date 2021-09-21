using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaration des variables : 
            String choix = "";
            int valeur1 = 0, valeur2 = 0;

            //Affichage d'un menu: 
            Console.WriteLine("Calculatrice console !");
            while (true) { 
            Console.WriteLine("Addition : tapez a");
            Console.WriteLine("Soustraction : tapez s");
            Console.WriteLine("Multiplication : tapez m");
            Console.WriteLine("Division : tapez d");


            //récupérez le choix: tant que le choix saisi est invalide : inviter le user à refaire un choix
            string[] correctValues = { "s", "a", "m", "d" };

            while(true)
            {
                Console.WriteLine("veuillez saisir votre choix : ");
                choix = Console.ReadLine();
                if (correctValues.Contains(choix))
                {
                    break;
                }
                else Console.WriteLine("vous avez saisi une valeur invalide");
            }

            //récupérer les valeurs : tant qu'elles ne sont pas valides, il doit en retaper
            //recup valeur 1

            do
            {
                Console.WriteLine("saisissez la première valeur : ");
                try
                {
                    valeur1 = Convert.ToInt32(Console.ReadLine());
                    break; //s'exécute s'il n'y a pas d'erreur"
                }
                catch (Exception)
                {
                    Console.WriteLine("Valeur non valide, veuillez saisir une valeur entière");
                }
            } while (true);

            //recup valeur 2
            do
            {
                Console.WriteLine("saisissez la seconde valeur : ");
                try
                {
                    valeur2 = Convert.ToInt32(Console.ReadLine());
                    break; //s'exécute s'il n'y a pas d'erreur"
                }
                catch (Exception)
                {
                    Console.WriteLine("Valeur non valide, veuillez saisir une valeur entière");
                }
            } while (true);

            //calcul
            double result = 0.0;
            switch (choix)
            {
                case "a":
                    result = valeur1+valeur2;
                    break;
                case "s":
                    result = valeur1 - valeur2;
                    break;
                case "m":
                    result = valeur1 * valeur2;
                    break;
                case "d":
                    result = (double)valeur1 / (double)valeur2;
                    break;
            }

            Console.WriteLine("le résultat est : "+result);
                string repeat = "";
                while (true) {
                    Console.WriteLine("Voulez-vous effectuer un nouveau calcul ? y/n");
                    repeat = Console.ReadLine();
                    if (repeat == "n") { Console.WriteLine("à bientôt ! "); break; }
                    else if (repeat != "y") { Console.WriteLine("je n'ai pas compris"); }
                    else break;
                }
                if(repeat == "n")break;
            }
            //maintenir la console active :
            Console.ReadLine();
        }
    }
}
