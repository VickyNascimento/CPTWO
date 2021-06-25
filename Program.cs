using System;

namespace Figuretas
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Circulo circ1 = new Circulo(2.0);

            Console.WriteLine("Raio:\t\t{0:0.0}", circ1.Raio);
            Console.WriteLine("Área:\t\t{0:0.0}", circ1.Area);
            Console.WriteLine("Perímetro\t{0:0.0}", circ1.Perimetro);

            circ1.Raio = -3.0;

            Console.WriteLine("Raio:\t\t{0:0.0}", circ1.Raio);
            Console.WriteLine("Área:\t\t{0:0.0}", circ1.Area);
            Console.WriteLine("Perímetro\t{0:0.0}", circ1.Perimetro);

            Retangulo retinha = new Retangulo(2.5, 10.0);

            Console.WriteLine("Altura:\t\t{0:0.0}", retinha.Altura);
            Console.WriteLine("Largura:\t\t{0:0.0}", retinha.Largura);
            Console.WriteLine("Área:\t\t{0:0.0}", retinha.Area);
            Console.WriteLine("Perímetro\t{0:0.0}", retinha.Perimetro);


            retinha.Altura = -2;
        }
    }
}