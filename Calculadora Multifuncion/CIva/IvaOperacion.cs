using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Multifuncion
{
    class IvaOperacion
    {
        public IvaOperacion()
        {
            Console.Clear();
            IvaPedirValor valor = new IvaPedirValor();
            double valor1 = valor.pedirvalor();
            Console.Clear();
            operar(valor1);



        }
        public double operar(double valor1)
        {
            double iva = 0;
            double subtotal = 0;
            iva = valor1 * 0.12;
            subtotal = valor1 - iva;
            Console.WriteLine("SubTotal: " + subtotal);
            Console.WriteLine("IVA: " + iva);
            Console.WriteLine("Total: " + valor1);
            return iva;
        }

    }
}
