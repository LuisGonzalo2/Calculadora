using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Multifuncion
{
    class Opciones:MensajesMenuGeneral
    {
        public Opciones()
        {

        }
        public int pedirOpcion()
        {
            String num = Console.ReadLine();
            int opcion = int.Parse(num);
            if (opcion == 1)
            {
                //Radio
                RadioOperacion valor1 = new RadioOperacion();
            }
            if (opcion == 2)
            {
                //Iva
                IvaOperacion valor = new IvaOperacion();
            }
            if (opcion == 3)
            {
                //Basico
                OpcionesMenuBasico elejir = new OpcionesMenuBasico();
                Console.Clear();
                elejir.menuBasico();
                elejir.Opcion();
            }
            if (opcion == 4)
            {
                //Porcentaje
                PorcentajeOperacion valor3 = new PorcentajeOperacion();
            }
            else if (opcion >= 5 || opcion <= 0)
            {
                erroropcion();
            }


            return opcion;
        }
    }
}
