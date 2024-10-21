using System;

namespace Ex11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Definició de variables
            int angle;
            string quadrant;
            
            //Dades d'entrada
            Console.Write("Introdueix un angle de entre 0 i 360 graus: ");
            angle = Convert.ToInt32(Console.ReadLine());

            //Algorisme i Dades de sortida
            quadrant = DeterminarQuadrant(angle);
            Console.Write($"L'angle es troba en: {quadrant}");
        }
        public static string DeterminarQuadrant(int angle)
        {
            string quadrant;
            angle = angle % 360;
            if (angle < 0)
                angle += 360;

            if (angle > 0 && angle <= 90)
                quadrant = "Primer quadrant";
                else if (angle > 90 && angle <= 180)
                    quadrant = "Segon quadrant";
                    else if (angle > 180 && angle <= 270)
                        quadrant = "Tercer quadrant";
                        else if (angle > 270 && angle <= 360)
                            quadrant = "Quart quadrant";
                            else
                                quadrant = "L'angle no està en cap quadrant";
            return quadrant;
        }


    }
}
