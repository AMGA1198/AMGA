using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciopizza
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Elija tipo de pizza \n 1:Vegetariana \n 2:Carnivora");
            var tipo = Console.ReadLine();
            if (tipo == "1")
            {
                var vegetariana = CrearVegetariana();

                Console.WriteLine(vegetariana.Ingredientes);
                Console.ReadLine();
            }
            if (tipo=="2")
            {
                var carni = CrearCarnivora();

                Console.WriteLine(carni.Ingredientes);
                Console.ReadLine();
            }

        }
        private static Vegetariana CrearVegetariana()
        {
 
            var vegetariana = new Vegetariana() {Tamanio="familiar",Tipo= "vegetariana", Ingredientes="vegetales, queso, masa" };
            return vegetariana;
        }
        private static carnivora CrearCarnivora()
        {

            var carni = new carnivora() { Tamanio = "familiar", Tipo = "carnivora", Ingredientes = "salame, carne, pollo" };
            return carni;
        }
    }
}
