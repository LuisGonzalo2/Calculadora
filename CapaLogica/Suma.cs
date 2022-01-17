using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    //Hereda metodos y propiedades de la clase Datos
    public class Suma : Datos
    {
        
        public Suma()
        {
            numeros = new List<double>();

        }
        public double Sumar()
        {
            double resultado = 0;
            //Todo lo que se haga en la expresion, se guardara en la variable ya creada resultado
            //Se coloca la coleccion de datos en este caso llamado numeros
            //seguidamente separada por un pinto el metodo Aggregate
            //requerimos un valor para un parametro de entrada llamado acumulador en este caso
            //el siguiente parametro es el numero, en este caso se llama item
            //y hacemos la operacion, seria como cualquier ciclo con acumulador, un while un foreach etc
            //nos ahorramos lineas de codigo y sumamos perfectamente
            resultado = this.numeros.Aggregate((acumulador, item) => acumulador += item);

            return resultado;

        }


    }
}
