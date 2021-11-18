using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Multifuncion
{
    class RadioPedirValor : PedirValores
    {
        public double Pi { get; set; }
        public RadioPedirValor()
        {
            mostrar();
        }
        public void mostrar()
        {
            MensajesMenuGeneral mostrar = new MensajesMenuGeneral();
            mostrar.menuRadio();
        }
    }
}
