using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Multifuncion
{
    class OpcionesMenuBasico : MensajesMenuGeneral
    {
        public OpcionesMenuBasico()
        {

        }
        public int Opcion()
        {
            String num = Console.ReadLine();
            int select = int.Parse(num);
            if (select == 1)
            {
                Suma sumar = new Suma();
            }
            if (select == 2)
            {
                Resta restar = new Resta();
            }
            if (select == 3)
            {

            }
            if (select == 4)
            {

            }
            else if (select >= 5 || select <= 0)
            {
                erroropcion();
            }
            return select;
        }
    }
}
