using System;
using System.Globalization;
namespace Uri_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, r;

            int resultado, resto, nota, moeda;


            Console.WriteLine();
            Console.Write("Digite o valor que será convertido : ");
            n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            r = (int)(n * 100 + 0.5);

            Console.WriteLine();
            Console.WriteLine("NOTAS");

            nota = 100;
            resultado = (int)r / (nota * 100);
            Console.WriteLine();
            Console.Write(resultado + " Nota(s)de 100");
            r = (int)r % (nota * 100);



            nota = 50;
            resultado = (int)r / (nota * 100);
            Console.WriteLine();
            Console.Write(resultado + " Nota(s)de 50");
            r = (int)r % (nota * 100);



            nota = 20;
            resultado = (int)r / (nota * 100);
            Console.WriteLine();
            Console.Write(resultado + " Nota(s)de 20");
            r = (int)r % (nota * 100);


            nota = 10;
            resultado = (int)r / (nota * 100);
            Console.WriteLine();
            Console.Write(resultado + " Nota(s)de 10");
            r = (int)r % (nota * 100);



            nota = 5;
            resultado = (int)r / (nota * 100);
            Console.WriteLine();
            Console.Write(resultado + " Nota(s)de 5");
            r = (int)r % (nota * 100);



            nota = 2;
            resultado = (int)r / (nota * 100);
            Console.WriteLine();
            Console.Write(resultado + " Nota(s)de 2");
            r = (int)r % (nota * 100);


            r = r / 100;
            Console.WriteLine();
            Console.Write(r+ " Nota(s)de 1");
        }
    }
}
