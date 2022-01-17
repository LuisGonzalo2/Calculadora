using System;
using CapaLogica;
namespace Calculadora_Multifuncion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int opcion = 0;
            double valor2 = 0;
            double numero1 = 0;
            double numero2 = 0;
            double resultado = 0;
            string respuesta = "";
            string pregunta = "Deseas Continuar? \n--> S o --> N";
            double iva = 1.12;
            double pi = 3.14;

            //Mensaje de titulo
            Console.WriteLine("Menu de Calculadora");



            //Variable operacion que referencia al algoritmo
            //Se instancia un default para que se pueda compilar sin ningun problema
            IOperacion operacion = new Resta();


            do
            {
                //Mensaje de menu
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Ingrese alguna de las siguientes opciones: \n1-Suma \n2-Resta \n3-Multiplicar \n4-Divir \n5-Iva \n6-Porcentaje \n7-Radio \n8-Salir");
                Console.WriteLine("-----------------------------------------------------");
                //variable que guarda la opcion escogida por el usuario
                opcion = Convert.ToInt16(Console.ReadLine());
                //opcion a terminar el programa
                if (opcion >= 8)
                {
                    break;
                }
                //Aqui se selecciona el algoritmo de acuerdo a la necesidad a calcular

                //Calcular Suma
                if (opcion == 1)
                {
                    do
                    {
                        //Intacia de la clase
                        Suma suma = new Suma();
                        Console.WriteLine("Ingrese cuantos numeros va a sumar");
                        //variable que guarda el valor ingresado
                        valor2 = double.Parse(Console.ReadLine());
                        //ciclo para agregar valores a la lista
                        for (int i = 0; i < valor2; i++)
                        {
                            Console.WriteLine("Ingrese el valor a Sumar ");
                            numero1 = double.Parse(Console.ReadLine());
                            suma.agregar(numero1);
                        }
                        Console.WriteLine("El resultado de la operaciones es {0}", suma.Sumar());
                        Console.WriteLine(pregunta);
                        respuesta = Console.ReadLine();
                        Console.Clear();

                        //verifica la respuesta, si no cicla
                    } while (respuesta.Equals("S"));
                }
                //Calcular Resta
                if (opcion == 2)
                {
                    do
                    {
                        //Mensajes para pedir valores
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Ingrese el primer numero");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Ingrese el segundo numero");
                        numero2 = Convert.ToDouble(Console.ReadLine());
                        //Se instancia
                        operacion = new Resta();
                        //Se guarda en una variable el resultado
                        resultado = operacion.Calcular(numero1, numero2);
                        Console.WriteLine("El resultado de la operaciones {0}", resultado);
                        Console.WriteLine(pregunta);
                        respuesta = Console.ReadLine();
                        Console.Clear();
                    } while (respuesta.Equals("S"));
                }
                //Calcular Multiplicacion
                if (opcion == 3)
                {
                    do
                    {
                        //Intacia de la clase
                        Multiplicacion multi = new Multiplicacion();
                        Console.WriteLine("Ingrese cuantos numeros va a multiplicar");
                        //variable que guarda el valor ingresado
                        valor2 = double.Parse(Console.ReadLine());
                        //ciclo para agregar valores a la lista
                        for (int i = 0; i < valor2; i++)
                        {
                            Console.WriteLine("Ingrese el valor a multiplicar ");
                            numero1 = double.Parse(Console.ReadLine());
                            multi.agregar(numero1);
                        }
                        Console.WriteLine("El resultado de la operaciones es {0}", multi.multiplicar());
                        Console.WriteLine(pregunta);
                        respuesta = Console.ReadLine();
                        Console.Clear();
                    } while (respuesta.Equals("S"));
                }
                //Calcular el Division
                if (opcion == 4)
                {
                    do
                    {
                        //Mensajes para pedir valores
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Ingrese el primer numero");
                        numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Ingrese el segundo numero");
                        numero2 = Convert.ToDouble(Console.ReadLine());
                        //se instancia
                        operacion = new Division();

                        //Se instancia
                        Division div = new Division();
                        //validamos si no contiene un 0 
                        bool validacion = div.validar(numero1, numero2);

                        //verificamos los numero ingresado
                        if (validacion == true)
                        {
                            //Se guarda el resultado en una variable
                            resultado = operacion.Calcular(numero1, numero2);
                            Console.WriteLine("El resultado de la operaciones {0}", resultado);
                            Console.WriteLine(pregunta);
                            respuesta = Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            //mensaje de error
                            Console.WriteLine("Error numero no valido");
                            Console.WriteLine(pregunta);
                            respuesta = Console.ReadLine();
                            Console.Clear();
                        }
                    } while (respuesta.Equals("S"));
                }


                //Calcular el Iva
                if (opcion == 5)
                {
                    do
                    {
                        //Mensajes para pedir valores
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Ingresa el valor total");
                        Console.WriteLine("----------------------");
                        decimal valor1 = decimal.Parse(Console.ReadLine());
                        //Se instancia
                        Iva impuesto = new Iva(valor1, iva);
                        Console.WriteLine("Subtotal " + impuesto.SubTotal());
                        Console.WriteLine("IVA " + impuesto.SacarImpuesto(impuesto.SubTotal()));
                        Console.WriteLine("Total " + valor1);
                        Console.WriteLine(pregunta);
                        respuesta = Console.ReadLine();
                        Console.Clear();
                    } while (respuesta.Equals("S"));
                }
                //Calcular el Porcentaje
                if (opcion == 6)
                {
                    do
                    {
                        //Mensajes para pedir valores
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Ingresa El valor");
                        Console.WriteLine("----------------------");
                        decimal valor = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el Porcentaje a Calcular");
                        decimal Numeroporcentaje = decimal.Parse(Console.ReadLine());
                        //Se instancia
                        Porcentaje verPorcentaje = new Porcentaje(valor, Numeroporcentaje);
                        Console.WriteLine("El " + Numeroporcentaje + "% de " + valor + " es: " + verPorcentaje.SacarElPorcentaje());
                        Console.WriteLine(pregunta);
                        respuesta = Console.ReadLine();
                        Console.Clear();
                    } while (respuesta.Equals("S"));
                }
                //Sacar el Radio
                if (opcion == 7)
                {
                    do
                    {
                        //Mensajes para pedir valores
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Ingresa El valor de la circunferencia");
                        Console.WriteLine("-------------------------------------");
                        decimal valor = decimal.Parse(Console.ReadLine());
                        //Se instancia
                        Radio sacarRadio = new Radio(valor, pi);
                        Console.WriteLine("La circunferencia es: " + valor + "\nEl Radio es: " + sacarRadio.SacarRadio());
                        Console.WriteLine(pregunta);
                        respuesta = Console.ReadLine();
                        Console.Clear();
                    } while (respuesta.Equals("S"));
                }
            } while (respuesta.Equals("N"));
        }
    }
}