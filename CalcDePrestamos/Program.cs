using System;
using System.Text;
using System.Threading;

namespace CalcDePrestamos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la Cantidad que le van a prestar: ");
            string valPrestamo = Console.ReadLine();
            double prestamo = Convert.ToDouble(valPrestamo);
            Console.WriteLine("Monto = {0}", prestamo);

            Console.WriteLine("Ingrese el interes que tendra: ");
            string valInteres = Console.ReadLine();
            double interes = Convert.ToDouble(valInteres);
            //decimal interesporciento = interes / 100;
            double interesporciento2 = interes / 100;
            Console.WriteLine("interes = {0}", interesporciento2);

            Console.WriteLine("Ingrese la cantidad Años en las que pagara el prestamo: ");
            string valAños = Console.ReadLine();
            int years2pay = Convert.ToInt32(valAños);
            double cantcuotas = years2pay * 12;
            Console.WriteLine("La cantidad de las cuotas sera de {0}", cantcuotas);

            double cuota = (prestamo * interesporciento2)*1.00/(1-Math.Pow(1+interesporciento2,-cantcuotas));

            Console.WriteLine("Mensualmente usted pagara un monto de: {0}", cuota);

        }
    }
}
