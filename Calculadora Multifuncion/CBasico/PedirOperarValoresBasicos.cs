using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Multifuncion
{
    class PedirOperarValoresBasicos : MensajesMenuGeneral
    {
        public PedirOperarValoresBasicos()
        {

        }

        public double suma()

        {
            double sumar = 0;
            mensajepedir1();
            String valor = Console.ReadLine();
            double num1 = double.Parse(valor);
            mensajepedir2();
            String valor2 = Console.ReadLine();
            double num2 = double.Parse(valor2);
            sumar = num1 + num2;
            return sumar;
        }
    }
}
