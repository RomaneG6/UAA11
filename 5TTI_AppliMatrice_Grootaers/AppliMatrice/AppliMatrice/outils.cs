using System;
using System.Collections.Generic;
using System.Text;

namespace AppliMatrice
{
    class outils
    {
        /// <summary>
        /// n et m sont non vide
        /// les valeurs de la matrice sont comprises entre 0 et 20
        /// </summary>
        /// <param name="matAleat">matrice créer aléatoirement</param>
        /// <param name="n">longueur de la matrice donnée par l'utilisateur</param>
        /// <param name="m">largeur de la matrice donnée par l'utilisateur</param>
        public void GenereMatrice(out int[,] matAleat, int n, int m)
        {
            matAleat = new int[n,m];
            Random nbrAl = new Random();
            for (int l = 0; l <= n - 1; l++)
            {
                for (int c = 0; c <= m - 1; c++)
                {
                    matAleat[l, c] = nbrAl.Next(0, 20 + 1);
                }
            }
        }
        /// <summary>
        /// resultat est vide
        /// </summary>
        /// <param name="mat">matrice créer aléatoirement</param>
        /// <param name="resultat">chaine de caractère contenant la matrice</param>
        public void ConcatMatrice(int[,] mat, out string resultat)
        {
            resultat = "";
            for (int l = 0; l < mat.GetLength(0); l++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    resultat = resultat + mat[l, c] + " ";
                }
                resultat = resultat + "\n";
            }
        }
        /// <summary>
        /// matF est vide
        /// </summary>
        /// <param name="matT1">première matrice créée aléatoirement</param>
        /// <param name="matT2">deuxième matrice créée aléatoirement</param>
        /// <param name="matF">matrice qui sera le résultat de l'addition des deux matrices</param>
        public void AdditionMat(int[,] matT1, int[,] matT2, out int[,] matF)
        {
            bool calcul;
            matF = new int[matT1.GetLength(0), matT1.GetLength(1)];
            if (matT1.GetLength(0) == matT2.GetLength(0) && matT1.GetLength(1) == matT2.GetLength(1))
            {
                calcul = true;
                for (int lT = 0; lT < matF.GetLength(0); lT++)
                {
                    for (int cT = 0; cT < matF.GetLength(1); cT++)
                    {
                        matF[lT, cT] = matT1[lT, cT] + matT2[lT, cT];
                    }
                }
            }
            else
            {
                calcul = false;
                Console.WriteLine("Le calcul ne peut pas se faire");
            }
        }
        /// <summary>
        /// matF est vide
        /// </summary>
        /// <param name="matT1">première matrice créée aléatoirement</param>
        /// <param name="matT2">deuxième matrice créée aléatoirement</param>
        /// <param name="matF">matrice qui sera le résultat du produit des deux matrices</param>
        public void multiMat(int[,] matT1, int[,] matT2, out int[,] matF)
        {
            bool calcul;
            int resultatC;
            matF = new int[matT1.GetLength(0), matT2.GetLength(1)];
            if (matT1.GetLength(1) == matT2.GetLength(0))
            {
                calcul = true;
                for (int lT = 0; lT < matF.GetLength(0); lT++)
                {
                    for (int cT = 0; cT < matF.GetLength(1); cT++)
                    {
                        resultatC = 0;
                        for (int compteur = 0; compteur < matT1.GetLength(1); compteur++)
                        {
                            resultatC = matT1[lT, compteur] * matT2[compteur, cT];
                            matF[lT, cT] = matF[lT, cT] + resultatC;
                        }
                    }
                }
            }
            else
            {
                calcul = false;
                Console.WriteLine("Le calcul ne peut pas se faire");
            }
        }
    }
}
