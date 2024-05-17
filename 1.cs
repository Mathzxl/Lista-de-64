using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 0, 5, -2, -5, 7 };
            int soma = A[0] + A[1] + A[5];
            Console.WriteLine(soma);
            A[4] = 100;
            for(int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
