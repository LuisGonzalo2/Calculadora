using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Multifuncion
{
    class PorcentajePedirValor:MensajesMenuGeneral
    {
        public PorcentajePedirValor()
        {
            Console.Clear();
            menuPorcentaje();
        }
        public double pedirValor()
        {
            String Valor = Console.ReadLine();
            double num = double.Parse(Valor);
            return num;
        }
        public double pedirPorcentaje()
        {
            String valor = Console.ReadLine();
            double num = double.Parse(valor);
            return num;
        }
    }
}
