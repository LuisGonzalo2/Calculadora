using System;
namespace CapaLogica
{
    public class Iva
    {
        //propiedades
        public decimal Numero { get; set; }
        public double Impuesto { get; set; }
        public Iva()
        {
        }
        //Sobrecarga del contructor 
        public Iva(decimal valor, double iva)
        {
            this.Numero = valor;
            this.Impuesto = iva;
        }

        //Metodo para sacar el subtotal
        public decimal SubTotal()
        {
            decimal div = Numero / Convert.ToDecimal(Impuesto);
            return div;
        }
        //Metodo para sacar el Impuesto
        public decimal SacarImpuesto(decimal subtotal)
        {
            return Numero - subtotal;
        }

    }
}
