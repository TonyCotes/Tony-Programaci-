namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definició de variables
            int hora, minut, segon;

            //Dades d'entrada
            Console.Write("Escriu una hora: ");
            hora = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escriu uns minuts: ");
            minut = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escriu uns segons: ");
            segon = Convert.ToInt32(Console.ReadLine());

            //Algorisme
        }
        static string Incrementa1Segon(int h, int m, int s)
        {
            s += 1;
            if (s >= 60)
            {
                m += 1;
                s -= 60;
            }
            if (m >= 60) 
            {
                h++;
                m -= 60;
            }
            if(h >= 24)
            {
                h -= 24;
            }
            return $"{h:00} : {m:00} : {s:0}";
        }
    }
}
