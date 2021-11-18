using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Multifuncion
{
    class Division : PedirOperarValoresBasicos
    {
        public Division()
        {
            double resultado = dividir();
            mostrar(resultado);
        }
        public double mostrar(double resul)
        {
            Console.WriteLine("El resultado de la division es: " + resul);
            return resul;
        }
    }
}
