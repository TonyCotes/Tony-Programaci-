namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int any;

            if (EsAnyFestivalHulukulu(any) && EsAnyTraspas(any) && EsAnyFestivalBulukulu(any))

        }
        static bool EsAnyTraspas(int any)
        {
            bool traspas;
            if (any % 400 == 0 || any % 100 != 0 && any % 4 == 0)
                traspas = true;
            else
                traspas = false;
            return traspas;
        }
        static bool EsAnyFestivalHulukulu(int any)
        {
            bool hulu;
            if (any % 15 == 0)
                hulu = true;
            else 
                hulu = false;
            return hulu;
        }
        static bool EsAnyFestivalBulukulu(int any)
        {
            bool bulu;
            if (any % )
        }
    }
}
