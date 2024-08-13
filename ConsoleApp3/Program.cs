using System.Linq.Expressions;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            try
            {
                //Definir variables

                int valorSexagesimal;
                double resultadoRadianes;
                const double Radianes = 0.0174532925;

                //Ingreso de datos

                Console.WriteLine("Ingrese el valor en grados sexagesimales");
                valorSexagesimal = int.Parse(Console.ReadLine());

                if (valorSexagesimal > 0)
                {

                    resultadoRadianes = valorSexagesimal * Radianes;
                    Console.WriteLine($"{valorSexagesimal} en grados equivalen a {resultadoRadianes} en radianes");


                }

                else

                {

                    Console.WriteLine("Este valor es incorrecto");

                }
            }
            catch (FormatException ex)

            {

                Console.WriteLine("Numero mal ingresado");
            }

            catch(OverflowException)

            {
                Console.WriteLine("Numero muy grande");

            }

            {

                
            }
            


            




        }
    }
}
