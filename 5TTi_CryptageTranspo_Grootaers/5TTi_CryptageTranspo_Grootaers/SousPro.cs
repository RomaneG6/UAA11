using System;
using System.Collections.Generic;
using System.Text;

namespace _5TTi_CryptageTranspo_Grootaers
{
    class SousPro
    {
        /// <summary>
        /// chaine non vide
        /// Fabriquer une copie de la chaine de départ sans les espaces
        /// </summary>
        /// <param name="chaine">chaîne à nettoyer</param>
        /// <param name="chaineSSEspaces">chaîne propre</param>
        public void RetireEspaces(string chaine, out string chaineSSEspaces)//Retirer les espaces
        {
            chaineSSEspaces = "";
            int lg = chaine.Length;
            for (int i = 0; i <= lg; i++)
            {
                if (chaine[i] != ' ')//bien mettre les appostrophes pcq le carac même de l'espace se fait avec des '' et pas avec des "" sinon le correcteur mettra que la syntaxe != ne marche pas avec les string
                {
                    chaineSSEspaces += chaine[i];//(= chaineSSEspaces = chaineSSEspaces + chaine[i])
                }
            }
        }
        /// <summary>
        /// cle et texte non vide,  texte est plus long que la cle, tout en majuscules et sans espace
        /// crée la matrice avec les dimensions permettant la réalisation du cryptage par transposition : clé dans la première ligne, un ligne avec des numéros d’ordre et le texte réparti sur les lignes suivantes
        /// </summary>
        /// <param name="cle">clé de cryptage</param>
        /// <param name="texte">texte à crypter</param>
        /// <param name="matrice">matrice de cryptage</param>
        public void DimensionneMat(string cle, string texte, out char[,]matrice)//Dimensionner la matrice de cryptage
        {
            int d1 =(int)(texte.Length/cle.Length)+2;//on met (int) pour forcer la division en entier et eviter les virgule
            int d2 = cle.Length;
            if (texte.Length % cle.Length != 0)
            {
                d1++;
            }
            matrice = new char[d1, d2];
        }
        /// <summary>
        /// cle, texte non vides, longueur de texte > longueur de cle, mat existe, mais est vide
        /// remplir la première ligne de la matrice avec cle, et le reste à partir de la 3° ligne avec le texte.
        /// </summary>
        /// <param name="cle">Clé de cryptage</param>
        /// <param name="texte">Texte à crypter</param>
        /// <param name="mat">matrice de cryptage</param>
        public void EcritChainesDansMat(string cle, string texte, ref char[,]mat)//Remplir Matrice
        {
            int j;
            for (j = 0; j <= mat.GetLength(1) - 1; j++)
            {
                mat[0, j] = cle[j];
            }
            int k = 0;
            for (int i = 2; i <= mat.GetLength(0) - 1; i++)
            {
                j = 0;
                while (j < mat.GetLength(1) && k < texte.Length)
                {
                    mat[i, j] = texte[k];
                    k++;
                    j++;
                }
            }
        }
        /// <summary>
        /// la première ligne de mat est remplie
        /// trier la première ligne d’une matrice par ordre alphabétique croissant
        /// </summary>
        /// <param name="mat">matrice dont on veut trier la première ligne</param>
        public void triLigne1(ref char[,] mat)//Trie ligne
        {
            char bulle;
            bool permut;
            do
            {
                permut = false;
                for (int i = 0; i <= mat.GetLength(1) - 1; i++)
                {
                    if (mat[0, i] > mat[0, i + 1])
                    {
                        bulle = mat[0, i];
                        mat[0, i] = mat[0, i + 1];
                        mat[0, i + 1] = bulle;
                        permut = true;
                    }
                }
            } while (permut == false);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cle"></param>
        /// <param name="mattri"></param>
        public void ClasseCle(string cle, out char[,] mattri)//Traitement séparé sur la clé
        {
            mattri = new char[3, cle.Length];
            for (int j = 0; j <= mattri.GetLength(1) - 1; j++)
            {
                mattri[0, j] = cle[j];
                mattri[2, j] = 0;
            }
            triLigne1(ref mattri);
            for (int j = 1; j <= mattri.GetLength(1) - 1; j++)
            {
                mattri[1, j - 1] = char.Parse(j.ToString());
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="mattri"></param>
        public void AttribueRang(char[,] mat, char[,] mattri)
        {
            for (int i = 0; i < mat.GetLength(1) - 1; i++)
            {
                bool trouve = false;
                j = 0;
                while (trouve == false && j < mattri.GetLength(1))
                {

                }
            }
        }
    }
}
