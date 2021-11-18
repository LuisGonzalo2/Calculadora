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
        public double restar()
        {
            double resta = 0;
            mensajepedir1();
            String valor = Console.ReadLine();
            double num1 = double.Parse(valor);
            mensajepedir2();
            String valor2 = Console.ReadLine();
            double num2 = double.Parse(valor2);
            resta = num1 - num2;
            return resta;
        }
        public double multiplicar()
        {
            double multiplica = 0;
            mensajepedir1();
            String valor = Console.ReadLine();
            double num1 = double.Parse(valor);
            mensajepedir2();
            String valor2 = Console.ReadLine();
            double num2 = double.Parse(valor2);
            multiplica = num1 * num2;
            return multiplica;
        }
    }
}
