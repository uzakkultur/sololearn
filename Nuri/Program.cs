using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuri
{
    class Program
    {
        static void Main(string[] args)
        {
            /* bu bir yorumdur */ 
            Console.WriteLine("Selam Dünyalı"); //Outputs_1 = "27"
          
            int x = 27;
            Console.WriteLine(x);

            int a = 10; //Outputs_1 = "a = 10; b = 20"
            double b = 20;
            Console.WriteLine("a={0}, b={1}", a, b);

            string isminiz;
            Console.WriteLine("Adınız nedir?");
            isminiz = Console.ReadLine();
            Console.WriteLine("Merhaba {0}", isminiz);

            Console.WriteLine("Yasınız kaç?"); //Yazıçıkar, veri alır, cevap verir
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} yaşındasınız", yas);

            const double PI = 3.14; //Sabitleyici galiba?

            
            int g = 4; //dört işlem
            int h = 10;
            Console.WriteLine(g + h);
            /* Peki bu neden olmuyor?
            Console.WriteLine(g + h, h - g, h * g, h / g);
            */

            int q = 8 / 4;
            Console.WriteLine(q);

            int u = 10 % 5;
            Console.WriteLine(u);

            int w = 3 + 2*2; //sonuç 7
            Console.WriteLine(w);

            int r = (3 + 2) * 2; //sonuç 10
            Console.WriteLine(r);

            int e = 10;
            e += 2;
            Console.WriteLine(e);
            e -= 1;
            Console.WriteLine(e);

        }

    }
}
