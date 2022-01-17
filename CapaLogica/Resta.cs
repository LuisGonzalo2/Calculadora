using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    //Strategy que implementa de la interfaz IOperacion
    public class Resta : IOperacion
    {
        //Metodo para obtener la resta
        public double Calcular(double num1, double num2)
        {
            //Definimos los parametros, en este caso recibe dos parametros y devuelve solo uno
            //luego creamos un nombre, y ponemos los parametros que recibe
            //seguidamente hacemos la operacion que en este caso es una resta
            Func<double, double, double> restar = (numero1, numero2) => numero1 - numero2;

            //devolvemos con el nombre que le pusimos seguido con los parametros 
            return restar(num1, num2);
        }
    }
}
