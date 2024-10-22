namespace Exercici_Notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definició de variables
            int nota;

            //Dades d'entrada
            Console.Write("Escriu la teva nota: ");
            nota = Convert.ToInt32(Console.ReadLine());

            //Algorisme
            if (nota < 0 || nota > 10)
                Console.WriteLine("Erroni");
            else if (nota >= 9)
                Console.WriteLine("Excel·lent");
            else if (nota >= 7)
                Console.WriteLine("Notable");
            else if (nota >= 5)
                Console.WriteLine("Aprovat");
            else
                Console.WriteLine("Suspès");
        }
    }
}
