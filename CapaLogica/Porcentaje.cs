using System;
namespace CapaLogica
{
    public class Porcentaje
    {
        //porpiedades
        public decimal Numero { get; set; }
        public decimal NumeroPorcentaje { get; set; }
        public Porcentaje()
        {

        }
        //Sobrecarga del contructor
        public Porcentaje(decimal valor, decimal porciento)
        {
            this.Numero = valor;
            this.NumeroPorcentaje = porciento;
        }
        //Metodo para obtener el porcentaje
        public decimal SacarElPorcentaje()
        {
            //Definimos los parametros, en este caso recibe dos parametros y devuelve solo uno
            //luego creamos un nombre, y ponemos los parametros que recibe
            //seguidamente hacemos la operacion que en este caso es una multiplicacion y una division
            Func<decimal, decimal, decimal> porcentaje = (num1, num2) => (num1 * num2) / 100;
            
            return porcentaje(Numero, NumeroPorcentaje);
        }

    }
}
