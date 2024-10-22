namespace Ex30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definició de variables
            int dia, mes;

            //Dades d'entrades
            Console.Write("Escriu un dia: ");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escriu un mes (format xx):");
            mes = Convert.ToInt32(Console.ReadLine());

            if (mes == 03 && dia >= 21 && dia <= 31 || mes == 04 && dia >= 1 && dia <= 30 || mes == 05 && dia >= 1 && dia <= 31 || mes == 06 && dia >= 1 && dia <= 20)
                Console.WriteLine("Primavera");
            else if (mes == 06 && dia >= 21 && dia <= 30 || mes == 07 && dia >= 1 && dia <= 31 || mes == 08 && dia >= 1 && dia <= 31 || mes == 09 && dia >= 1 && dia <= 20)
                Console.WriteLine("Estiu");
            if (mes == 09 && dia >= 21 && dia <= 30 || mes == 10 && dia >= 1 && dia <= 31 || mes == 11 && dia >= 1 && dia <= 30 || mes == 12 && dia >= 1 && dia <= 20)
                Console.WriteLine("Tardor");
            else if (mes == 12 && dia >= 21 && dia <= 31 || mes == 01 && dia >= 1 && dia <= 31 || mes == 02 && dia >= 1 && dia <= 28 || mes == 03 && dia >= 1 && dia <= 20)
                Console.WriteLine("HIvern");

        }
    }
}
