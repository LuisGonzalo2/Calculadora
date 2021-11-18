using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Multifuncion
{
    class Suma : PedirOperarValoresBasicos
    {
        public Suma()
        {
            double resultado = suma();
            mostrar(resultado);

        }
        public double mostrar(double resul)
        {
            Console.WriteLine("El valor es: " + resul);
            return resul;
        }
    }
}
