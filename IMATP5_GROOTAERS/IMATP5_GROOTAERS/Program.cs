using System;

namespace IMATP5_GROOTAERS
{
    class Program
    {
        static void Main(string[] args)
        {
            outils tools = new outils();
            string chaine;
            int N;
            int[,] maTriP;
            string chainC;

            Console.WriteLine("Donnez la taille de la matrice :");
            N = int.Parse(Console.ReadLine());
            tools.TriMatP(out maTriP, N, out chaine);
            tools.ChainC(maTriP, N, out chainC);
        }
    }
}
