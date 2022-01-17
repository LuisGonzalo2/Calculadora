using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Datos
    {
        public List<double> numeros { get; set; }
        public void agregar(double numero)
        {
            numeros.Add(numero);
        }
    }
}
