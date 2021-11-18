using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Multifuncion
{
    class Multiplicacion : PedirOperarValoresBasicos
    {
        public Multiplicacion()
        {
            double resultado = multiplicar();
            mostrar(resultado);
        }
        public double mostrar(double resul)
        {
            Console.WriteLine("El resultado de la multiplicacion es: " + resul);
            return resul;
        }
    }
}
