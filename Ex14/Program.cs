using System.Timers;

namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definició de variables
            int num;
            string resultat;

            //Dades d'entrada
            Console.Write("Escriu un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            resultat = CapiCua(num);
            Console.Write(resultat);
        }
        static string CapiCua(int num)
        {
            string resultat;

            if (num / 1000 == num % 10)
                resultat = $"El nombre {num} és Cap i Cua";
            else
                resultat = $"El nombre {num} no és Cap i Cua";

            return resultat;
        }
    }
}