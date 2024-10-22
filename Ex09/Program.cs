namespace Ex09
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Definició de variables
            double notaExamen, notaPractiques;
            string notaQualitativa;

            //Dades d'entrada
            Console.Write("Introdueix la nota de l'examen: ");
            notaExamen = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introdueix la nota de les pràctiques: ");
            notaPractiques = Convert.ToDouble(Console.ReadLine());

            //Algorisme i Dades de sortida
            notaQualitativa = NotaQualitativa(notaExamen, notaPractiques);
            Console.Write($"La nota qualitativa és: {notaQualitativa}");
        }
        public static string NotaQualitativa(double notaExamen, double notaPractiques)
        {
            string nota;
            double notaGlobal;
            notaGlobal = (notaExamen * 0.8) + (notaPractiques * 0.2);
            
            if (notaExamen < 3 || notaPractiques < 3)
                nota = "Suspens";

            if (notaGlobal < 5)
                nota = "Suspens";
                else if (notaGlobal >= 5 && notaGlobal < 7)
                    nota = "Aprovat";
                    else if (notaGlobal >= 7 && notaGlobal < 9)
                        nota = "Notable";
                        else
                            nota = "Excel·lent";
            return nota;
        }
    }
}
