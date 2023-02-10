using System;
using System.Collections.Generic;
using System.Text;

namespace AppliTab
{
    public struct MethodTraiTab
    {
        public void GenereTab(out int[] tAleat, int nbrV, int borneDIntervalles, int borneFIntervalles)
        {
            Random nAleat = new Random();
            
            tAleat = new int[nbrV];

            for (int compteur = 0; compteur <= nbrV - 1; compteur++)
            {
                tAleat[compteur] = nAleat.Next(borneDIntervalles, borneFIntervalles + 1);
            }
        }
        public void AfficherTab(int[] tab, out string resultat)
        {
            resultat = "";

            for (int compteur = 0; compteur <= tab.Length - 1; compteur++)
            {
                resultat = resultat + tab[compteur] + " ";
            }
            
        }
        public void AfficherTabS(string[] tab, out string resultat)
        {
            resultat = "";

            for (int compteur = 0; compteur <= tab.Length - 1; compteur++)
            {
                resultat = resultat + tab[compteur] + " ";
            }

        }
        public void FonctionMixed(int[] tJours, string[] tMois, out string[] tMixed)
        {
            int j = 0;
            tMixed = new string[24];
            for (int compteur = 0; compteur < (tJours.Length)*2 - 1; compteur = compteur + 2)
            {
                tMixed[compteur] = tMois[j];
                tMixed[compteur+1] = tJours[j].ToString(); //Méthode pour convertir n'importe quel type en string
                j++;
            }
        }

        public void TabClassement(int[] tPositifRempli, out int[] tImpair, out int[] tPair)
        {
            tPair = new int[20];
            tImpair = new int[20];
            int j = 0;
            int n = 0;
            for (int i = 0; i <= 20 - 1; i++)
            {
                if (tPositifRempli[i] % 2 == 0)
                {
                    tPair[j] = tPositifRempli[i];
                    j++;
                }
                else
                {
                    tImpair[n] = tPositifRempli[i];
                    n++;
                }
            }
            while (j != 20 - 1)
            {
                tPair[j] = 0;
                j++;
            }
            while (n != 20 - 1)
            {
                tImpair[n] = 0;
                n++;
            }
        }
        public void TabFibonacci(out int[] tFibo, int n)
        {
            tFibo = new int[n - 1];
            int i = 2;
            tFibo[0] = 1;
            tFibo[1] = 1;
            while (i != n)
            {
                tFibo[i] = tFibo[i - 1] + tFibo[i - 2];
                i++;
            }
        }
        public void TabDecal(ref int[] tabI, int val)
        {
            int nbOcc = 0;
            for (int i = 0; i < tabI.Length; i++)
            {
                if (tabI[i] == val)
                {
                    nbOcc++;
                }
                else
                {
                    tabI[i - nbOcc] = tabI[i];
                }
            };
            for (int i = tabI.Length - nbOcc; i < tabI.Length; i++)
            {
                tabI[i] = val;
            }
        }
    }
}
