using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TietovisaC
{
    class KarvaLakkiProgram
    {
        static void Main(string[] args)
        {
            Kysymys kysymys = new Kysymys();
            string vastaus = "";
            int pisteet = 0;
            string oikeaVastaus = "";
            int kysymystenLkm = 0;

            Console.WriteLine("Tervetuloa Tietovisaan! Kysyn 10 kysymystä");
            Console.WriteLine("Vastaa annettuihin kysymyksiin K tai E");
            Console.WriteLine("****************************************");

            for (int i = 0; i < 10; i++)
            {
                string[]kysVas= kysymys.KysyKysymys().Split('*');
                Console.WriteLine(kysVas[0]);
                Console.Write("Vastaus: ");

                vastaus = Console.ReadLine().ToUpper();

                oikeaVastaus = kysVas[1];
                //Vastauksen arviointi
                if (vastaus==oikeaVastaus)                  
                {
                    pisteet++;
                    kysymystenLkm++;
                    Console.WriteLine("Oikea vastaus!");
                }
                else
                {
                    kysymystenLkm++;
                    Console.WriteLine("Vastaus väärin :(");
                }
                Console.WriteLine("Vastattuja kysymyksiä " + kysymystenLkm+ "/10.");
                Console.WriteLine("___________________________");
        
    }

            Console.WriteLine("Pistemääräsi on: " + pisteet);
            Console.ReadKey();



        }
    }
}

