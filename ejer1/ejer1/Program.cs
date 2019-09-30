using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    class Program
    {
        static void Main(string[] args)
        {
            var perro = crearPerro();
        }
        private static Perro crearPerro()
        {
            var firulais = new Perro() { color = "verde", Especie = "Pitbull", Nombre = "MAX", Raza = "XXX", Tamanio = 100 };
            var max = new Perro() { color = "blanco", Nombre = "MAX"};
            var reptil = new Reptiles() { color = "cualquiera", Especie = "camaleon", Nombre = "Rango" };
            var delfin = new Mamiferos() { color = "Piel", Especie = "humano", Tamanio = 1.75, NumeroPatas = 2, Peso = 85.70 };
            return firulais;
        }
    }
}
