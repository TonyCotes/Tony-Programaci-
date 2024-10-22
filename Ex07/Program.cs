namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Definició de variables
            int velocitat;
            string sancio;

            //Dades d'entrada
            Console.Write("Introdueix la velocitat del vehicle: ");
            velocitat = Convert.ToInt32(Console.ReadLine());

            //Algorisme i Dades de sortida
            sancio = Sancio(velocitat);
            Console.Write($"Sanció: {sancio}");
        }
        static string Sancio(int velocitat)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string multa;
            if (velocitat >= 80 && velocitat <= 99)
                multa = "100€ de multa";
                    else if (velocitat >= 100 && velocitat <= 129)
                    multa = "300€ de multa";
                        else if (velocitat >= 130)
                        multa = "600€ de multa i retirada de carnet";
                            else
                            multa = "sense sanció";
            return multa;
        }
    }
}
