using System;
namespace CapaLogica
{
    public class Radio
    {
        //Propiedades
        public decimal Numero { get; set; }
        public double Pi { get; set; }

        public Radio()
        {

        }
        //Sobrecarga del contructor
        public Radio(decimal valor, double pi)
        {
            this.Numero = valor;
            this.Pi = pi;
        }
        //Metodo para obtener El radio
        public decimal SacarRadio()
        {
            //Definimos los parametros, en este caso recibe dos parametros y devuelve solo uno
            //luego creamos un nombre, y ponemos los parametros que recibe
            //seguidamente hacemos la operacion que en este caso es una division con multiplicacion
            Func<decimal, double, decimal> radio = (numero, pi) => numero / (2 * Convert.ToDecimal(Pi));

            
            return radio(Numero, Pi);
        }
    }
}
