using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    //Strategy que implementa de la interfaz IOperacion
    public class Multiplicacion : IOperacion
    {
        //Metodo para calcular la multiplicacion
        public double Calcular(double num1, double num2)
        {
            return num1 * num2;

        }
    }
}
