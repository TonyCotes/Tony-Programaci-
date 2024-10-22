using System;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definició de variables
            int angle;
            string quadrant;
            
            //Dades d'entrada
            Console.Write("Introdueix un angle de entre -360 i 360 graus: ");
            angle = Convert.ToInt32(Console.ReadLine());

            //Algorisme i Dades de sortida
            quadrant = DeterminarQuadrant(angle);
            Console.Write($"L'angle es troba en: {quadrant}");
        }
        static string DeterminarQuadrant(int angle)
        {
            string resultat;
            angle = angle % 360;
            if (angle < 0)
                angle += 360;
            
            if (angle >= 0 && angle < 90)
                resultat = "Primer quadrant";
                else if (angle < 180)
                    resultat = "Segon quadrant";
                    else if (angle < 270)
                        resultat = "Tercer quadrant";
                        else if (angle < 360)
                            resultat = "Quart quadrant";
                            else
                                resultat = "L'angle no està en cap quadrant";
            return resultat;
        }


    }
}
