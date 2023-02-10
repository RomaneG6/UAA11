using System;

namespace AppliTab
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodTraiTab tools = new MethodTraiTab();
            int nbrV;
            int[] tAleat;
            string resultat;
            int borneDIntervalles;
            int borneFIntervalles;
            int[] tJours = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] tMois = new string[] {"Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre"};
            string[] tMixed;
            int answer;
            int[] tPositifRempli;
            int[] tImpair;
            int[] tPair;
            int n;
            int[] tFibo;
            int[] tabI;
            int val;

            Console.WriteLine("Choisissez l'option que vous voulez(1, 2, 3, 4 ou 5)");
            answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine("Choisissez la longueur de tableau que vous désirez");
                nbrV = int.Parse(Console.ReadLine());
                Console.WriteLine("Choisissez la valeure par laquelle vous voulez commencer votre tableau");
                borneDIntervalles = int.Parse(Console.ReadLine());
                Console.WriteLine("Choisissez la valeure par laquelle vous voulez finir votre tableau");
                borneFIntervalles = int.Parse(Console.ReadLine());

                tools.GenereTab(out tAleat, nbrV, borneDIntervalles, borneFIntervalles);
                tools.AfficherTab(tAleat, out resultat);
                Console.WriteLine(resultat);
            }
            else if (answer == 2)
            {
                tools.FonctionMixed(tJours, tMois, out tMixed);
                tools.AfficherTabS(tMixed, out resultat);
                Console.WriteLine(resultat);
            }
            else if (answer == 3)
            {
                tools.GenereTab(out tPositifRempli, 20, 0, 100);
                tools.TabClassement(tPositifRempli, out tImpair, out tPair);
                tools.AfficherTab(tPositifRempli, out resultat);
                tools.AfficherTab(tImpair, out resultat);
                tools.AfficherTab(tPair, out resultat);
                Console.WriteLine(resultat);
            }
            else if (answer == 4)
            {
                Console.WriteLine("Choisissez le nombre de valeurs que composera cette suite");
                n = int.Parse(Console.ReadLine());
                tools.TabFibonacci(out tFibo, n);
            }
            else if (answer == 5)
            {
                Console.WriteLine("Choisissez la longueur de tableau que vous désirez");
                nbrV = int.Parse(Console.ReadLine());
                Console.WriteLine("Choisissez la valeure par laquelle vous voulez commencer votre tableau");
                borneDIntervalles = int.Parse(Console.ReadLine());
                Console.WriteLine("Choisissez la valeure par laquelle vous voulez finir votre tableau");
                borneFIntervalles = int.Parse(Console.ReadLine());

                tools.GenereTab(out tabI, nbrV, borneDIntervalles, borneFIntervalles);
                tools.AfficherTab(tabI, out resultat);
                Console.WriteLine(resultat);
                Console.WriteLine("Choisissez une valeur indésirable dans votre tableau");
                val = int.Parse(Console.ReadLine());
                tools.TabDecal(ref tabI, val);
                tools.AfficherTab(tabI, out resultat);
                Console.WriteLine(resultat);
            }
        }
    }
}