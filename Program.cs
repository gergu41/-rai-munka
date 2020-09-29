using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<string> alma = new List<string> {
         "Anna","Kati","Béla","Tamás","Géza"
     };
        static List<float> magassag = new List<float>();
        static List<int> ak = new List<int>();
        static List<int> ab = new List<int>();
            static void Main(string[] args)
        {
            
            for (int i=0;i<alma.Count;i++)
            {
                Console.WriteLine(alma[i]);
            }
            Console.WriteLine("Add meg az első számot:");
            for(int i=0;i<=4;i++)
            {
                int ab = Int32.Parse(Console.ReadLine());
                magassag.Add(ab);
                Console.Clear();
                Console.WriteLine("Add meg a következő számot");
            }
            float atlag = 0;
            float osszeg = 0;
            for(int i=0;i<magassag.Count;i++)
            {
                osszeg += magassag[i];
            }
            atlag = osszeg / (magassag.Count);
            Console.WriteLine("Átlag:" + atlag);
            alma.Sort();
            int szam;
            Random rnd = new Random();
            for(int i=0;i<=20;i++)
            {
                szam = rnd.Next(1, 41);
                ak.Add(szam);
            }


            int temp;
            for(int i=0;i<ak.Count;i++)
            {
                for (int j=1;j<ak.Count;j++)
                {
                    if(ak[j-1]>ak[j])
                    {
                        temp = ak[j];
                        ak[j] = ak[j - 1];
                        ak[j - 1] = temp;
                    }
                }
            }
            for(int i=0;i<ak.Count;i++)
            {
                Console.WriteLine(ak[i]);
            }
            float atlagg = 0;
            float osszegg = 0;
            for (int i = 0; i < ak.Count; i++)
            {
                osszegg += ak[i];
            }
            atlagg = osszegg / (magassag.Count);
            Console.WriteLine("Átlag:" + atlagg+" Összeg: "+osszegg);
            int a = 0;
            for (int i = 0; i < ak.Count; i++)
            {
                if(ak[i]%10==0)
                {
                    a++;
                }
            }
            Console.WriteLine(a);


           



            Console.ReadKey();

            
        }
    }
}
