
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
            return (Numero * NumeroPorcentaje) / 100;
        }

    }
}
