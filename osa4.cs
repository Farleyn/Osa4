using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_csharp
{
    internal class Osa4_funktsioonid
    {
        public static void Faili_kirjutamine()
        {
            try
            {
                string path =  @"..\..\..\Kuud.txt"; 
                StreamWriter text = new StreamWriter(path, true); 
                Console.WriteLine("Sisesta mingi tekst: ");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
                text.Close();
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine("Midagi");
                } // Fail suletakse automaatselt siin
            }
            catch (Exception e)
            {
                Console.WriteLine("Mingi viga failiga");
            }
           
        }
        public static void Faili_lugemine()
        {

            try
            {
                string path = @"..\..\..\Kuud.txt";
                StreamReader text = new StreamReader(path);
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine(laused);
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
        }

        public static void Ridade_lugemine(string file)
        {
            
            List<string> kuude_list = new List<string>();
            try
            {

                string path = @$"..\..\..\{file}";
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);

                }
                foreach (string i in kuude_list) Console.WriteLine(i);
                
            }
            
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }

        }
        public static List<string> Ridade_lugemine_listiks(string file)
        {

            List<string> kuude_list = new List<string>();
            try
            {

                string path = @$"..\..\..\{file}";
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);

                }
                

            }

            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }
            return kuude_list;

        }
    }
}
