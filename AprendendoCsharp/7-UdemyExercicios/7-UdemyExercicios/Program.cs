using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_UdemyExercicios
{
    class Program
    {
        static void Main(string[] args)

        {
            int A = 10, B = 20;

            A = B;
            B = A;

            Console.WriteLine(A);
            Console.WriteLine(B);

            Console.ReadLine();

        }
    }
}
