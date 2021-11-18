using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Multifuncion
{
    class IvaPedirValor : PedirValores
    {
        public double Impuesto { get; set; }
        public IvaPedirValor()
        {
            mostrar();
        }
        public void mostrar()
        {
            MensajesMenuGeneral mostrar = new MensajesMenuGeneral();
            mostrar.menuIva();
        }
    }
}
