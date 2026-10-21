using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Masina> parcare = new List<Masina>();

        parcare.Add (new Masina());
        parcare.Add (new MasinaRally());

        foreach (Masina m in parcare)
        {
            if(m is MasinaRally)
            {
                Console.WriteLine(" Am gasit o masina de raliu ");

                MasinaRally rally = m as MasinaRally;
                if (rally != null)
                {
                    rally.SunetPocnituri();
                }
                else
                {
                    Console.WriteLine(" Asta e o masina obisnuita ");
                }
            }
        }
    }
}