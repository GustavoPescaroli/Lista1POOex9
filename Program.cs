using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1POOex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            retangulo r;
            r = new retangulo();


            Console.WriteLine("Digite o valor da base");
            r.setb(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o valor da altura");
            r.seth(double.Parse(Console.ReadLine()));
            r.calcular();
            Console.WriteLine("O valor da base {0} da altura {1} área é de {2}", r.getb(), r.geth(), r.geta());

        }
    }
}
