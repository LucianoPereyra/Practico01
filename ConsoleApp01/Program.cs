namespace ConsoleApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Definicion de variables

              
               

                //Ingreso de datos

                Console.Write("Ingrese el primer valor a sumar: ");
                var numero1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo valor a sumar: ");
                var numero2 = double.Parse(Console.ReadLine());

                //Obtener resutados

                var resultadoSuma = numero1 + numero2;

                //Mostrar info obtenida

                Console.WriteLine($"La suma de {numero1} y {numero2} es {resultadoSuma}");

            }
            catch (Exception)
            {

                Console.WriteLine("Algo se ingresó mal");

            }
        }
    }
}
