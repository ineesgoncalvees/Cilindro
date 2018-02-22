using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilindro {
    class Program {
        static void Main(string[] args) {
            int a;
            int r;
            double v;
            double sa;

            string pa = "Escreve a altura do circulo.";
            Console.WriteLine(pa);
            string area = Console.ReadLine();

            string pr = "Escreve o raio do circulo.";
            Console.WriteLine(pr);
            string raio = Console.ReadLine();

            a = Convert.ToInt32(area);
            r = Convert.ToInt32(raio);

            v = Math.PI * Math.Pow(r, 2) * a;
            sa = 2 * Math.PI * r * (r + a);

            Console.WriteLine("Volume:" + v);
            Console.WriteLine("Area da Superficie:" + sa);


        }
    }
}
