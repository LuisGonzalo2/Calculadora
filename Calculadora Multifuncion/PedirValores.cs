using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Multifuncion
{
    class PedirValores
    {
        public PedirValores()
        {

        }
        public int pedirvalor()
        {
            String valor = Console.ReadLine();
            int num = int.Parse(valor);
            return num;
        }

    }
}
