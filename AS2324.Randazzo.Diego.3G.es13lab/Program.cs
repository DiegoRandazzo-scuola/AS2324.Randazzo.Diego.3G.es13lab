using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace AS2324.Randazzo.Diego._3G.es13lab
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("indicare il numero di persone");
            int dim= Convert.ToInt32(Console.ReadLine());
            int[] età = new int[dim];
            int[] peso = new int[dim];
            CaricaVettori(ref peso, ref età);
            int min = peso[0], max = peso[0];
            double media=0;
            Statistiche(ref peso, ref media, ref min, ref max);
            Console.WriteLine($"la media dei pesi delle persone è {media}, il valore minimo è {min} e il valore massimo è {max}");
            Ordina(ref peso, ref età);
            for (int i = 0; i < età.Length; i++)
            {
                Console.Write(età[i]);
            }
            for(int j=0; j<peso.Length; j++)
            {
                Console.Write(peso[j]);
            }
        }
        static void CaricaVettori(ref int [] peso, ref int [] età)
        {
            Random random = new Random();
            foreach (int i in peso)
            {
                peso[i] = random.Next(50, 101);
                età[i] = random.Next(18, 100);
            }
        }
        static void Statistiche(ref int[] peso, ref double media, ref int min, ref int max)
        {
            int somma = 0;
            int conta = 0;
            foreach (int i in peso)
            {
                somma+= peso[i];
                if (peso[i] > max)
                {
                    max = peso[i]; 
                }
                if (peso[i] < min)
                {
                    min = peso[i];
                }
                conta++;
            }
            media = somma / conta;
        }
        static void Ordina(ref int[] peso, ref int[] età)
        {
            for(int i = 0; i < età.Length - 1; i++)
            {
                for (int j = 0; j < età.Length - i - 1; j++)
                {
                    if (età[j] < età[j+1])
                    {
                        int temp = età[j];
                        età[j] = età[j + 1];
                        età[j + 1] = temp;
                        int temp2 = peso[j];
                        peso[j] = peso[j + 1];
                        peso[j + 1] = temp2;
                    }
                }

            }
        }

    }
}
