using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Multifuncion
{
    class RadioOperacion
    {
        public RadioOperacion()
        {
            Console.Clear();
            RadioPedirValor pedirvalor = new RadioPedirValor();
            double valor1 = pedirvalor.pedirvalor();
            Console.Clear();
            operar(valor1);
        }
        public double operar(double valor1)
        {
            double resul1 = 0;
            double radio = 0;
            double pi = 3.14;
            resul1 = 2 * pi;
            radio = valor1 / resul1;
            Console.WriteLine("Circunferencia: " + valor1);
            Console.WriteLine("Radio: " + radio + " cm");
            return radio;
        }

    }
}
