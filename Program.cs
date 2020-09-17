using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;


            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;

            Console.WriteLine(edadPersona1);




            var edadPersona5 = 27;

            Console.WriteLine(edadPersona5);




            double temperatura= 34.5;

            int temperaturaMadrid;

            //conversión explícita
            //casting

            temperaturaMadrid = (int)temperatura;

            //conversíón implícita

            int habitantesCiudad = 10000000;

            long habitantesCidudad2018 = habitantesCiudad;

            float pesoMaterial = 5.78F;

            double pesoMaterialPrec = pesoMaterial;

            Console.WriteLine(temperaturaMadrid);

            Console.WriteLine(habitantesCidudad2018);

            Console.WriteLine(pesoMaterialPrec);
        }
    }
}
