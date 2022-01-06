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
        public Boolean validar(double numeroUno, double numeroDos)
        {
            //Aqui validamos los numeros que sean mayor a 0
            Boolean validacion = true;
            if (numeroUno > 0 && numeroDos > 0)
            {
                validacion = true;
            }
            else
            {
                validacion = false;
            }

            return validacion;
        }

    }
}
