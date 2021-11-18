using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Multifuncion
{
    class Program
    {
        static void Main(string[] args)
        {
            MensajesMenuGeneral mostrar = new MensajesMenuGeneral();
            mostrar.menuBasico();
            OpcionesMenuBasico elejir = new OpcionesMenuBasico();
            elejir.Opcion();
            Console.ReadKey();
        }
    }
}
