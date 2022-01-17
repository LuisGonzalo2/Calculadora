using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Multiplicacion : Datos
    {
        public Multiplicacion()
        {
            numeros = new List<double>();
        }
        //Metodo para calcular la multiplicacion
        public double multiplicar()
        {
            double resultado = 0;
            //Todo lo que se haga en la expresion, se guardara en la variable ya creada resultado
            //Se coloca la coleccion de datos en este caso llamado numeros
            //seguidamente separada por un pinto el metodo Aggregate
            //requerimos un valor para un parametro de entrada llamado acumulador en este caso
            //el siguiente parametro es el numero, en este caso se llama item
            //y hacemos la operacion, seria como cualquier ciclo con acumulador, un while un foreach etc
            //nos ahorramos lineas de codigo y multiplicamos perfectamente
            //cabe recalcar que los datos se consiguen en una lista previamente agregados llamada numeros

            resultado = this.numeros.Aggregate((acumulador, item) => acumulador * item);

            return resultado;
        }
    }
}
