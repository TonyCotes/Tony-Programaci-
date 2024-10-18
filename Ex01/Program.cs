namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definició de variables
            int a = 5;
            int b = 3;
            int c = -10;

            bool resultat1 = a > 3;
            Console.WriteLine($"RESULTAT 1: {resultat1}");

            bool resultat2 = a > c;
            Console.WriteLine($"RESULTAT 2: {resultat2}");

            bool resultat3 = b != c;
            Console.WriteLine($"RESULTAT 3: {resultat3}");

            bool resultat4 = a == 3;
            Console.WriteLine($"RESULTAT 4: {resultat4}");

            bool resultat5 = a * b == 15;
            Console.WriteLine($"RESULTAT 5: {resultat5}");

            bool resultat6 = c / b < a;
            Console.WriteLine($"RESULTAT 6: {resultat6}");

            bool resultat7 = c / b == -10;
            Console.WriteLine($"RESULTAT 7: {resultat7}");

            bool resultat8 = a + b + c == 5;
            Console.WriteLine($"RESULTAT 8: {resultat8}");

            bool resultat9 = (a + b == 8) && (a - b == 2);
            Console.WriteLine($"RESULTAT 9: {resultat9}");

            bool resultat10 = (a + b == 8) || (a - b == 6);
            Console.WriteLine($"RESULTAT 10: {resultat10}");

            bool resultat11 = a > 3 && b > 3 && c < 3;
            Console.WriteLine($"RESULTAT 11: {resultat11}");

        }
    }
}
