using ProjetDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test c#");

            Tools.MethodeDll();

            // Ceci est un commentaire

            /* Ceci est un commentaire
             * sur plusieurs lignes */

            #region Les Variables

            //Variable: zone mémoire contenant une valeur typée
            //Types simples (types valeur): entier, réel, booleen, char
            // Types complexes (types référence): Array, string, enum, classe et objet

            //entiers : byte(1 o); shrt (2 o), int (4 o), long (8 o)
            // pour déclarer une variable : Type nom_variable = valeur;

            int myint = 10;
            int myint2 = myint;
            Console.WriteLine("La valeur de ma variable myint = " + myint); //ici le + est une concaténation

            char mychar = 'a'; // simple cote

            string chaine = "aaaaa"; // double cote

            //réel : float (4 o); double (8 o); decimal(16 o)
            double myDboule = 15.2;

            bool mybool = true;

            //appel du garbage collector : cet appel explicite n'implique pas le passage immédiat du garbage collector
            GC.Collect();


            //le mot clé var : 
            var myVariable = "10.6"; // le compilateur défini le type de la variable -> inférence du type

            //myVariable = 10; -> erreur de compilation car le type ne correspond pas à celui qui lui a été donné à l'origine

            //constante : une valeur que l'on ne peut pas modifier; (par convention les constantes sont en majuscules
            const double MYCONSTANTE = 29.8;

            #endregion

            #region Opérateurs

            //Opérateurs arythmétiques : + - * / %

            int mod = (9 % 2);

            Console.WriteLine(mod);//1 -> le reste de la division

            //opérateurs d'incrémentation et de décrémentation : 
            int incr = 3;
            incr++; // +1

            //opérateurs combinés : += -= *= /=
            int comb = incr += 5;

            //opérateurs de comparaison == != < <= > >=

            // opérateurs logiques : && || ^ (ou exclusif) ! (non logique)
            // table logique
            // A    B   (A&&B)  (A||B)  (A^B)
            // v    v   v       v       f     
            // v    f   f       v       v
            // f    v   f       v       v
            // f    f   f       f       f

            // caractères d'échappement
            Console.WriteLine("\tvoici une tabulation\npuis un retour à la ligne\n c'est dingue");
            string chemin = "C:\\lechemin\\gagner";

            //chaine verbatim : 
            string chemin2 = @"c:\test";//pas besoin d'échapper les \

            string paragraphe = @"Bonjour; 
Je suis une formation                   celle-ci est en c#";//la mise en forme est conservée.s


            //formattage de chaine en utilisant l'interpolation :
            int x = 20; int y = 30;
            Console.WriteLine("x = "+x+", y = "+y);// concaténation
            Console.WriteLine("x =  {0}, y = {1}", x, y);// interpolation
            Console.WriteLine($"x = {x}, y = {y}");// autre forme d'interpolation

            #endregion

            #region Convertion de type

            //converion implicite :
            byte myByte = 10;
            int myInteger = myByte;
            // la conversion se fait de manière implicite et fonctionne car le type int est codé sur plus d'octets que le Byte.

            // convertion explicite : 
            // 1 - utilisation d'un cast : il suffit d'annoncer le type voulu. Risque de perte de données si la valeur est trop grande pour le type dans lequel il est casté
            int myInteger2 = 10;
            byte myByte2 = (byte)myInteger2;
            // 2 - utilisation de la classe convert
            byte myByte3 = Convert.ToByte(myInteger2);
            // 3 - utilisation de la méthode parse : 
            // byte myByte4 = byte.Parse(myInteger2); -> marche pas, la méthode parse concerne les conversions entre types non compatibles
            string str = "20";
            int chiffre = int.Parse(str);
            int chiffre2 = Convert.ToInt32(str);

            Console.WriteLine("Merci de saisir votre : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("votre âge est : "+age);
            #endregion

            #region Conditions

            //if(condition est vraie) { instructions} else {autres instructions}
            int nb = 5;
            if (nb > 0)
            {
                Console.WriteLine("nb est positif");
            }
            else if (nb == 0)
            {
                Console.WriteLine("nb est nul");
            }
            else
            {
                Console.WriteLine("nb est négatif");
            }

            //Switch: une variante des conditions if
            int note = 10;
            switch (note)
            {
                case 0:
                    Console.WriteLine("recalé");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("juste la moyenne");
                    break;
                default:
                    break;
            }


            //opérateur ternaire :

            bool myboolean = (10 > 5) ? false : true; // ici ça renvoie faux car la condition est vraie, donc on prend la première valeur : false.



            #endregion

            #region Boucles

            //boucles conditionnelles : while, do while :



            //boucles itératives : for, for each;

            // for : connaitre le nombre d'itérations
            for (int index = 0; index <5; index++)
            {
                Console.WriteLine("je suis à l'index"+index);
            }


            //foreach : permet de faire le parcours complet d'une collection
            int[] tab = { 1, 2, 3, 4, 5 };
            foreach(var o in tab){
                Console.WriteLine(o);
            }

            //while
            int valeur = 1;
            while (valeur < 5)
            {
                Console.WriteLine("valeur");
                valeur++;

                //sortir de la boucle while si valeur ==3 :
                if (valeur == 3) break;
            }

            //do-while : pareil mais permet d'executer la boucle au moins une fois
            do
            {
                Console.WriteLine(valeur);
                valeur++;
            } while (valeur < 10);
            #endregion

            #region Tableaux

            //tableaux = ensemble d'éléments de taille fixe

            int[] monTableau = new int[3]; // tableau de 3 elements

            monTableau[0]= 10;
            monTableau[1] = 20;
            monTableau[2]= 30;

            int[] monTableau2 = { 10, 20, 30 };
            Console.WriteLine("taille du tableau = " + monTableau.Length);
            
            //lister le contenu du tableau
            foreach (var item in monTableau2)
            {
                Console.WriteLine(item);
            }

            for (int indice =0; indice < monTableau.Length; indice ++)
            {
                Console.WriteLine(monTableau[indice]);
            }

            //tableau à 2 dimensions : 
            int[,] matrice = new int[2, 3];
            matrice[0, 0] = 5;
            matrice[0, 1] = 10;
            matrice[0, 2] = 15;
            matrice[1, 0] = 20;
            matrice[1, 1] = 25;
            matrice[1, 2] = 30;

            
            int[,] matrice2 = { { 10, 20, 30 }, { 40, 50, 60 } };
            Console.WriteLine(matrice[1,0]);//40 (2eme ligne, 1ere colonne)

            Console.WriteLine("Nombre de lignes de matrice2 : " + matrice2.GetLength(0));//nombre de lignes du tableau (dimension 0)
            Console.WriteLine("Nombre de lignes de matrice2 : " + matrice2.GetLength(1));//nombre de lignes du tableau (dimension 1)
            Console.WriteLine("Nombre d'éléments dans la matrice = "+ matrice2.Length);//nombre de "cases"
            Console.WriteLine("Nombre de dimensions dans matrice2 = "+ matrice.Rank);

            //Lister le contenu de matrice 2 : 
            for (int ligne = 0; ligne < matrice2.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < matrice2.GetLength(1); colonne++)
                {
                    Console.WriteLine("l'élément à la ligne " + ligne +" et à la colonne " + colonne +" est : " +matrice2[ligne, colonne]);
                }
            }

            #endregion

            #region Methodes
            // Methode : ensemble d'instruction réutilisable
            // En prog objet, deux méthodes possibles :
            //procédure : méthode qui ne renvoie aucun résultat,
            //Fonction : méthode avec un retour de valeur

            
            Console.WriteLine(MesMethodes.Somme(2, 3));// on a accès à la méthode Somme sans avoir besoin de l'instancier car c'est une méthode static

            int res = MesMethodes.Somme(10, 20);
            Console.WriteLine("somme de 10 et 20 est "+res);


            MesMethodes.Afficher("ceci est un message à afficher");

            int[] tableau = { 10, 0, 20, 15 };

            MesMethodes.Afficher(tableau);
            Console.WriteLine(MesMethodes.Somme(tableau));
            Console.WriteLine(MesMethodes.Mean(tableau));
            Console.WriteLine(MesMethodes.Min(tableau));
            #endregion

            //maintenir la console active
            Console.ReadLine();

            //authentification OK
            
        }
    }
}
