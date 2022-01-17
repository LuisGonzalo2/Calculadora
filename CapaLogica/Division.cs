using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    //Strategy que implementa de la interfaz IOperacion
    public class Division : IOperacion
    {
        //Metodo para calcular la division 
        public double Calcular(double num1, double num2)
        {
            return num1 / num2;
        }
        //Metodo para validar la division

        public bool validar(double numeroUno, double numeroDos)
        {
            //Definimos los parametros, en este caso recibe dos parametros y devuelve solo uno
            //luego creamos un nombre, y ponemos los parametros que recibe
            //seguidamente hacemos la operacion que en este caso evaluamos y devolvemos un valor bool
            //nos ahorramos el poner el if para evaluar si en una division existen numeros a dividir que sean 0
            Func<double, double, bool> evaluar = (num1, num2) => num1 > 0 && num2 > 0;
          
            return evaluar(numeroUno, numeroDos);

        }

    }
}
