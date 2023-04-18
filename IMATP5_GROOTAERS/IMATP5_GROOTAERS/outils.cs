using System;
using System.Collections.Generic;
using System.Text;

namespace IMATP5_GROOTAERS
{
    class outils
    {
        public void TriMatP(out int[,] maTriP, int N, out string chaine)
        {
            int resultat;
            chaine = "";
            maTriP = new int[N, N];
            int compteur = 1;
            for (int Nlignes = 0; Nlignes <= maTriP.GetLength(0) - 1; Nlignes++)
            {
                for (int Ncolonnes = 0; Ncolonnes <= maTriP.GetLength(1) - 1; Ncolonnes++)
                {
                    maTriP[Nlignes, Ncolonnes] = 0;
                    maTriP[Nlignes, 0] = 1;
                    while (maTriP[Nlignes, Ncolonnes] != 0)
                    {
                        resultat = maTriP[Nlignes, Ncolonnes] + maTriP[Nlignes, Ncolonnes + compteur];
                        maTriP[Nlignes + compteur, Nlignes + compteur] = resultat;
                    }
                    compteur++;
                    if (maTriP[Nlignes, Ncolonnes] == 0)
                    {
                        maTriP[Nlignes + 1, Ncolonnes] = 0;
                    }
                    chaine = chaine + maTriP[Nlignes, Ncolonnes];
                }
            }
        }
        public void ChainC(int[,] maTriP, int N, out string chainC)
        {
            chainC = "";
            int compteur = 0;
            for (int Nlignes = 0; Nlignes <= maTriP.GetLength(0) - 1; Nlignes++)
            {
                for (int Ncolonnes = 0; Ncolonnes <= maTriP.GetLength(1) - 1; Ncolonnes++)
                {
                    string terme = maTriP[Nlignes.GetLength(0), Ncolonnes++] + "a" ^ N - compteur + "b" ^ compteur;
                    chainC = chainC + terme;
                }
                chainC = chainC + "+";
            }
        }
    }
}
