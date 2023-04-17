using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cegesauto
{
    internal class Program
    {
        class Adat
        {
            public int nap;
            public string oraperc;
            public string rendszam;
            public int id;
            public int km;
            public int kibe;
        }

        static void Main(string[] args)
        {
            /*
             * BEOLVASÁS 0,1
             * 
            List<string[]> lista = new List<string[]>();                   

            using (StreamReader f = new StreamReader("autok.txt"))
            {
                while (!f.EndOfStream)
                {
                    string sor = f.ReadLine(); // "7 57 36 7 59 59"
                    string[] sortomb = sor.Split(' ');
                    lista.Add(sortomb);
                }
            }
            */

            //BEOLVASÁS 0,2

            string[] sorok=File.ReadAllLines("autok.txt", Encoding.Default);
            List<Adat> lista = new List<Adat>();
            {
                foreach (string s in sorok)
                {
                    Adat adat = new Adat();
                    string [] sortomb = s.Split(' ');
                    adat.nap = int.Parse(sortomb[0]);
                    adat.oraperc = sortomb[1];
                    adat.rendszam = sortomb[2];
                    adat.id = int.Parse(sortomb[3]);
                    adat.km = int.Parse(sortomb[4]);
                    adat.kibe = int.Parse(sortomb[5]);
                }

                Console.WriteLine(lista.Count);

                //keresés: utolsó 0-ás

                static Adat feladat2(List<Adat> list)
                {
                    for (int i = lista.Count - 1; i <= i; i--)
                    {

                    }
                }





            }



        }
    }
}
