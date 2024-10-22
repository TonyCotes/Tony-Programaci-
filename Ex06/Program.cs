namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definició de variables
            string nomEquipLocal, nomEquipVisitant, resultat;
            int golsEquipLocal, golsEquipVisitant;
            
            //Dades d'entrada
            Console.Write("Introdueix el nom de l'equip local: ");
            nomEquipLocal = Console.ReadLine();

            Console.Write("Introdueix el nombre de gols de l'equip local: ");
            golsEquipLocal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introdueix el nom de l'equip visitant: ");
            nomEquipVisitant = Console.ReadLine();

            Console.Write("Introdueix el nombre de gols de l'equip visitant: ");
            golsEquipVisitant = int.Parse(Console.ReadLine());

            //Algorisme i Dades de sortida
            resultat = InformeResultat(nomEquipLocal, golsEquipLocal, nomEquipVisitant, golsEquipVisitant);
            Console.WriteLine(resultat);

        }
        static string InformeResultat(string nomLocal, int golsLocal, string nomVisitant, int golsVisitant)
        {
            string informe;
            if (golsLocal == golsVisitant)
                informe = $"Han empatat {nomLocal} i {nomVisitant} amb un resultat de {golsLocal} a {golsVisitant}.";
                else if (golsLocal > golsVisitant)
                    informe = $"{nomLocal} ha guanyat al {nomVisitant} amb un resultat de {golsLocal} a {golsVisitant}.";
                    else
                    informe = $"{nomVisitant} ha guanyat al {nomLocal} amb un resultat de {golsVisitant} a {golsLocal}.";
            return informe;
        }
    }
}
