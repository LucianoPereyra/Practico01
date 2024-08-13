namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definir variables

            try
            {
                int valorEur, valorUsd, valorCny, valorArs;

                //Ingreso de datos

                Console.WriteLine("Ingrese el valor en ARS");
                valorArs = int.Parse(Console.ReadLine());

                valorCny = valorArs / 118;
                valorEur = valorArs / 923;
                valorUsd = valorArs / 845;


                if (valorArs > 0)

                {
                    Console.WriteLine($"El equivalente en yuanes es: {valorCny}$ ");
                    Console.WriteLine($"El equivalente en euros es: {valorEur}$ ");
                    Console.WriteLine($"El equivalente en dólares es: {valorUsd}$ ");
                }

                else
                {
                    Console.WriteLine("El valor ingresado es negativo");

                }




            }

            catch (FormatException ex)
            {

                Console.WriteLine("Numero mal ingresado" + Environment.NewLine + ex.Message);
            }

            catch (OverflowException ex)
            {
                Console.WriteLine("Número demasiado grande" + Environment.NewLine + ex.Message);
            }

        }
    }
}


