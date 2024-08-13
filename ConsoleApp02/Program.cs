using System.ComponentModel.Design;

namespace ConsoleApp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Ingrese el primer numero");
            var numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número");
            var numero2 = int.Parse(Console.ReadLine());

            //Proceso

            var suma=numero1 + numero2;
            var resta= numero1 - numero2;
            var producto=numero1*numero2;

            Console.WriteLine($"La suma es {suma}");
            Console.WriteLine($"La resta es {resta}");
            Console.WriteLine($"El producto es {producto}");

            if (numero2!=0)
            {
                double cociente = numero1 / numero2;
                Console.WriteLine($"El cociente es {cociente}");
            }
            else
            {

                Console.WriteLine("No se puede dividir por cero");

            }

        }
    }
}
