using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Multifuncion
{
    class Resta : PedirOperarValoresBasicos
    {
        public Resta()
        {
            double resultado = restar();
            mostrar(resultado);
        }
        public double mostrar(double resul)
        {
            Console.WriteLine("El valor es: " + resul);
            return resul;
        }

    }
}
