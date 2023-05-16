using System;

namespace _5TTi_CryptageTranspo_Grootaers
{
    class Program
    {
        static void Main(string[] args)
        {
            SousPro tools = new SousPro();
            string chaine;
            string chaineSSEspaces;
            string cle;
            string texte;
            char [,]matrice;
            char[,] mat;

            Console.WriteLine("Ecrivez votre message");
            chaine = Console.ReadLine();
            tools.RetireEspaces(chaine, out chaineSSEspaces);//Retirer les espaces
            Console.WriteLine(chaineSSEspaces);
            Console.WriteLine("Tapez le clé désirée");
            cle = Console.ReadLine();
            Console.Clear(); 
            tools.DimensionneMat(cle, texte, out matrice);//Dimensionner la matrice de cryptage
            tools.EcritChainesDansMat(cle, texte, ref mat);//Remplir Matrice
            tools.triLigne1(ref mat);//Trie ligne
        }
    }
}
