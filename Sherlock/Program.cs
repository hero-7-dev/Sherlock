using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sherlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string Word = Console.ReadLine();
            Console.WriteLine(isValid(Word));
            Console.ReadLine();
          
        }
        public static string isValid(String s)
        {

           
        
                char[] c = s.ToCharArray();

            Dictionary<string, int> str = new Dictionary<string, int>();


                int[] arr = new int[c.Length];
             
            for (int i = 0; i < c.Length; i++)
            {

                if (str.ContainsKey(c[i].ToString()))
                   {
                    str[c[i].ToString()] = str[c[i].ToString()]+1;
                }
                    else
                      { str.Add(c[i].ToString(), 1); }
                   
                        
            }
            var myList = str.ToList();
            
            myList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            

            int first = myList[0].Value;
            int second = myList[1].Value;
            int secondLast = myList[myList.Count - 2].Value;
            int last = myList[myList.Count - 1].Value;


            if (first == last) return "YES";

            if (first == 1 && second == last) return "YES";

            if (first == second && second == secondLast && secondLast == (last - 1)) return "YES";

            return "NO";
        }
    }
}
