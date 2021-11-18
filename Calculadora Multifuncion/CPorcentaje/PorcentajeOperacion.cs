using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Multifuncion
{
    class PorcentajeOperacion
    {
        public PorcentajeOperacion()
        {
            PorcentajePedirValor valores = new PorcentajePedirValor();
            double valor = valores.pedirValor();
            valores.mensaje2Porcentaje();
            double porcentaje = valores.pedirPorcentaje();
            double multiplicar = valor * porcentaje;
            double resultado = operar(multiplicar);
            valores.mensajeResultadoPorcentaje(resultado);
        }
        public double operar(double multi)
        {
            double resultado;
            resultado = multi / 100;
            return resultado;
        }

    }
}
