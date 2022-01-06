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
            return Numero / (2 * Convert.ToDecimal(Pi));
        }
    }
}
