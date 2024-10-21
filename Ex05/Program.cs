namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definició de variables
            int num;

            //Dades d'entrada
            Console.Write("Escriu el numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Dades de sortida + Algorisme

            if (EsParell(num))
                Console.WriteLine("Aquest nombre és parell");
            else
                Console.WriteLine("Aquest nombre és senar");
            if (EsMultipleDe7(num))
                Console.WriteLine("Aquest nombre és multiple de 7");
            else
                Console.WriteLine("Aquest nombre no és multiple de 7");
            
        }

        public static bool EsParell(int n)
        {
            bool parell;
            if ((n % 2) == 0)
                parell = true;

            else
                parell = false;
            return parell;
        }
        public static bool EsMultipleDe7(int n)
        {
            bool multiple7;
            if ((n % 7) == 0)
                multiple7 = true;
            else
                multiple7 = false;
            return multiple7;
        }
    }
}
