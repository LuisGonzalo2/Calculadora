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
        public void errornumero()
        {
            Console.WriteLine("No se puede dividir entre 0");
        }
        //General
        public void erroropcion()
        {
            Console.WriteLine("No existe esa opcion");
        }
        public void generalmenu()
        {
            //menu General
            Console.WriteLine("--------------------------");
            Console.WriteLine("Elije lo que deseas Calcular");
            Console.WriteLine("1. Radio");
            Console.WriteLine("2. IVA");
            Console.WriteLine("3. Basico");
            Console.WriteLine("4. Porcentaje");
            Console.WriteLine("---------------------------");
        }

        //-------------------------------------------------------------------------
        //Porcentajes
        public void menuPorcentaje()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Menu de Porcentaje");
            Console.WriteLine("Ingrese el valor");
            Console.WriteLine("------------------");
        }

        public void mensaje2Porcentaje()
        {
            Console.WriteLine("Ingresa el porcentaje que deseas calcular");
        }
        public string mensajeResultadoPorcentaje(double valor)
        {
            Console.WriteLine("El valor total es " + valor);
            return "";
        }
    }
}