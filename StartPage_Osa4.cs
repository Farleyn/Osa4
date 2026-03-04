using System;

class StartPage_Osa4
{
    static void Main(string[] args)
    {
        bool töötab = true;

        while (töötab)
        {
            Console.WriteLine("Osa 4 Failitöötlus");
            Console.WriteLine("1 - Salvesta lemmik Itaalia toit");
            Console.WriteLine("2 - Kuva kogu menüü");
            Console.WriteLine("3 - Koostisosade haldus (muutmine, otsing, salvestus)");
            Console.WriteLine("0 - Välju");
            Console.Write("Vali tegevus: ");

            string valik = Console.ReadLine();

            switch (valik)
            {
                case "1":
                    Osa4_Funktsioonid.SalvestaLemmikToit();
                    break;
                case "2":
                    Osa4_Funktsioonid.KuvaMenuu();
                    break;
                case "3":
                    Osa4_Funktsioonid.KoostisosadeHaldus();
                    break;
                case "0":
                    töötab = false;
                    break;
                default:
                    Console.WriteLine("Vale valik!");
                    break;
            }
        }
    }
}