using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Multifuncion
{
    class MensajesMenuGeneral
    {
        public MensajesMenuGeneral()
        {

        }
        //Basico
        public void menuBasico()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("Ingrese el numero de la operacion a calcular");
            Console.WriteLine("1- Realizar una Suma");
            Console.WriteLine("2- Realizar una Resta");
            Console.WriteLine("3- Realizar una Multiplicacion");
            Console.WriteLine("4- Realizar una Division");
            Console.WriteLine("********************************************");
        }
        public void mensajepedir1()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("Ingresa el segundo numero ");
        }
        public void mensajepedir2()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("Ingresa el segundo numero");
        }

        //General
        public void erroropcion()
        {
            Console.WriteLine("No existe esa opcion");
        }
    }
}