namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definir variables

          
            double distanciaMillas, distanciaYardas, distanciaMetros, distanciaKm;

            //Ingreso de datos

            Console.WriteLine("Ingrese la distancia en km");

            distanciaKm= double.Parse(Console.ReadLine());

            distanciaMetros = distanciaKm * 1000;
            distanciaMillas = distanciaKm * 0.621371192;
            distanciaYardas = distanciaKm * 1093.6133;

            if (distanciaKm > 0) 
            
            {

                Console.WriteLine($"La distancia en metros es: {distanciaMetros} ");
                Console.WriteLine($"La distancia en millas es: {distanciaMillas} ");
                Console.WriteLine($"La distancia en yardas es: {distanciaYardas} ");
            
            }

            else
            {
                Console.WriteLine("El valor es negativo");
            }
 
        }
    }
}
