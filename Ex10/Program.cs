namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definició de variables
            int any;
            string resultat;
            
            //Dades d'entrada
            Console.Write("Introdueix un any: ");
            any = Convert.ToInt32(Console.ReadLine());

            //Algorisme i dades de sortida
            resultat = Segle(any);
            Console.Write(resultat);
        }
        static string Segle(int any)
        {
            string segle;
            if (any >= 1701 && any <= 1800)
                segle = "Segle XVIII";
                else if (any >= 1801 && any <= 1900)
                    segle = "Segle XIX";
                    else if (any >= 1901 && any <= 2000)
                        segle = "Segle XX";
                        else if (any >= 2001 && any <= 2100)
                            segle = "Segle XXI";
                            else
                                segle = "Any invàlid";
            return segle;
        }
    }
}
