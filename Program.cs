using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {

          ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.euro = 1.45;

            Console.WriteLine(obj.convierte(50));
            
        }
    } 
    
    class circulo
    {

       private const double pi = 3.1416;

        public double calculoArea (int radio)
        {

            return pi * radio * radio;

        }


    }

    class ConversorEuroDolar
    {

       private double euro = 1.253;

        public double convierte(double cantidad)
        {

            return cantidad * euro;

        }
        public void cambiarValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = 1.253;

            else
                euro = nuevoValor;


        }

    }
}
