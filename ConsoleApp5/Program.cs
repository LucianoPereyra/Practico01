namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definir variables

            double resultadoPerimetro, resultadoSuperficie;
            double valorRadio;

            //Ingresar datos

            Console.Write("Ingrese el valor del radio: ");

            valorRadio = double.Parse(Console.ReadLine());

            resultadoPerimetro = 2 * Math.PI *  valorRadio;
            resultadoSuperficie= Math.PI * Math.Pow(valorRadio, 2);


            //Proceso

            if (valorRadio > 0) 

            {

                Console.WriteLine($"El valor de la superficie es {resultadoSuperficie}");
                Console.WriteLine($"El valor de el perimetro es {resultadoPerimetro}");
            }

             else

            {

                Console.Write("El valor ingresado no es correcto");
            }

                
               

            

            

        }
    }
}
