using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello "+name);
            //String bb = "23";


            string aa = "022";
            var bb = aa.ToCharArray();
            
            List<int> termsListLast = new List<int>();
            List<string> termsListResult = new List<string>();

            for (int k = 0; k < aa.Length; k++)
            {
                int[] Aint = Array.ConvertAll(bb, c => (int)Char.GetNumericValue(c));
                termsListLast = calculateDivide(Aint[k],Aint.Sum()- Aint[k]);
                for (int l = 0; l < termsListLast.Count; l++)
                {
                    Aint[k] = termsListLast[l];
                    termsListResult.Add(String.Join("",Aint));
                }              
               
                
            }

            Console.WriteLine("Count=> "+termsListResult.Distinct().ToList().Count);
            foreach (var item in termsListResult.Distinct().ToList())
            {                
                Console.Write(item+", ");
            }
            Console.ReadLine();
        }

        public static List<int> calculateDivide(int number, int total)
        {
           
            List<int> termsList = new List<int>();
            List<int> termsListTwo = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                if ((i  + total) % 3 == 0)
                {
                    if (i  < 10)
                    {
                        termsList.Add(i);
                      
                    }
                   
                }
            }
            termsListTwo = termsList.Distinct().ToList();
            return termsList;
        }
    }
}
