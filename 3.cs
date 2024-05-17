using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];
            for (int i = 0; i < vet1.Length; i++)
            {
                Console.WriteLine($"Dê o {i + 1} nùmero");
                vet1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vet1.Length; i++)
            {
                vet2[i] = vet1[i] * 2;
            }
            for (int i = 0; i < vet1.Length; i++)
            {
                Console.Write(vet1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < vet1.Length; i++)
            {
                Console.Write(vet2[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
