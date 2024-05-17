using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[6];
            for(int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine($"Dê o {i + 1} nùmero");
                vet[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
