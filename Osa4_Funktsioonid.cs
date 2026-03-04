using System;
using System.Collections.Generic;
using System.IO;

public static class Osa4_Funktsioonid
{
    // Ülesanne 1
    public static void SalvestaLemmikToit()
    {
        try
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ("C:\\Users\\opilane\\Downloads\\Retseptid.txt"));
            StreamWriter sw = new StreamWriter(path, true);

            Console.Write("Sisesta üks Itaalia toit: ");
            string toit = Console.ReadLine();

            sw.WriteLine(toit);
            sw.Close();

            Console.WriteLine("Toit salvestatud!\n");
        }
        catch (Exception)
        {
            Console.WriteLine("Viga faili kirjutamisel!\n");
        }
    }

    // Ülesanne 2
    public static void KuvaMenuu()
    {
        try
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\opilane\\Downloads\\Retseptid.txt");
            StreamReader sr = new StreamReader(path);
            string sisu = sr.ReadToEnd();
            sr.Close();

            Console.WriteLine("\n--- MENÜÜ ---");
            Console.WriteLine(sisu);
        }
        catch (Exception)
        {
            Console.WriteLine("Viga faili lugemisel või faili ei eksisteeri!\n");
        }
    }

    // Ülesanded 3–5
    public static void KoostisosadeHaldus()
    {
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C:\\Users\\opilane\\Downloads\\Koostisosad.txt");

        if (!File.Exists(path))
        {
            File.WriteAllLines(path, new string[] { "Tomat", "Juust", "Ketšup" });
        }

        List<string> list = new List<string>();

        try
        {
            foreach (string rida in File.ReadAllLines(path))
            {
                list.Add(rida);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Viga faili lugemisel!");
            return;
        }

        // Muudame esimese elemendi
        if (list.Count > 0)
            list[0] = "Kvaliteetne oliiviõli";

        // Eemaldame Ketšupi
        list.Remove("Ketšup");

        Console.WriteLine("\n--- Uuendatud koostisosad ---");
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }

        // Ülesanne 4 Otsing
        Console.Write("\nSisesta koostisosa otsimiseks: ");
        string otsitav = Console.ReadLine();

        if (list.Contains(otsitav))
            Console.WriteLine("Koostisosa on olemas!");
        else
            Console.WriteLine("Seda koostisosa meil retseptis ei ole.");

        // Ülesanne 5 Salvestamine
        try
        {
            File.WriteAllLines(path, list);
            Console.WriteLine("\nUus retsept on edukalt faili salvestatud!");
        }
        catch (Exception)
        {
            Console.WriteLine("Viga salvestamisel!");
        }
    }
}