using System;

namespace AppliMatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            outils tools = new outils();
            int[,] matT1;// première matrice qu'on utilisera dans les opérations avenir
            int[,] matT2;// deuxième matrice qu'on utilisera dans les opérations avenir
            int[,] matF;// matrice finale qui sera le resultat de chaque opérations
            int n;// variable qui informe de la longueur de la matrice cad la premiére dimension
            int m;// variable qui informe de la hauteur de la matrice cad la duexième dimension
            int answer;// variable qui permet de savoir quelle opération va choisir l'utilisateur
            string resultat;// variable qui permet d'afficher les matrices
            string recom = "oui";// variable qui permet à l'utilisateur de choisir q'il veut relancer le jeu

            while (recom == "oui")//boucle qui permet de recommencer si on tape le mot "oui" à la fin
            {
                Console.WriteLine("Choisissez la première dimension de votre matrice");
                m = int.Parse(Console.ReadLine());
                Console.WriteLine("Choisissez la deuxième dimension de votre matrice");
                n = int.Parse(Console.ReadLine());
                tools.GenereMatrice(out matT1, n, m);//créer la matrice
                tools.ConcatMatrice(matT1, out resultat);//converti en chaine de carac pour l'afficher
                Console.WriteLine(resultat);

                Console.WriteLine("Choisissez la première dimension de votre matrice");
                m = int.Parse(Console.ReadLine());
                Console.WriteLine("Choisissez la deuxième dimension de votre matrice");
                n = int.Parse(Console.ReadLine());
                tools.GenereMatrice(out matT2, n, m);
                tools.ConcatMatrice(matT2, out resultat);
                Console.WriteLine(resultat);

                Console.WriteLine("Choisissez l'option que vous voulez(1 ou 2)");
                answer = int.Parse(Console.ReadLine());

                if (answer == 1)//addition
                {
                    tools.AdditionMat(matT1, matT2, out matF);
                    tools.ConcatMatrice(matF, out resultat);
                    Console.WriteLine(resultat);
                }
                else if (answer == 2)//multiplication
                {
                    tools.multiMat(matT1, matT2, out matF);
                    tools.ConcatMatrice(matF, out resultat);
                    Console.WriteLine(resultat);
                }
                Console.WriteLine("Souhaitez-vous relancer le programme ?oui/non");
                recom = Console.ReadLine();
            }
        }
    }
}
