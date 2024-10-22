namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definició de variables
            int hores, minuts, segons, hhmmss;

            //Dades d'entrada
            Console.Write("Escriu una hora en format hhmmss: ");
            hhmmss = Convert.ToInt32(Console.ReadLine());

            //Algorisme
            hores = hhmmss / 10000;
            minuts = hhmmss % 10000 / 100;
            segons = hhmmss % 100;

            //Dades de sortida
            if (HoraValida(hores, minuts, segons))
                Console.WriteLine("Aquesta hora és valida");
            else
                Console.WriteLine("Aquesta hora no és valida");


        }
        static bool HoraValida(int h, int m, int s)
        {
            bool horaValida = h < 24 || h >= 0 && m < 60 || m >= 0 && s < 60 || s >= 0;
           /* if (h >= 24 || h < 0 && m >= 60 || m < 0 && s >= 60 || s < 0)
                horaValida = false;
            else
                horaValida = true;*/
            
            return horaValida;
        }
    }
}
