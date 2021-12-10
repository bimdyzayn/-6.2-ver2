using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_6._2
{
   
 
    class Palindr
    {
        public static bool Palindromtest(string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                if (s[i] != s[j])

                    return false;
                
            }
            return true;
        }

        static void Main()
        {
            string s;
            Console.WriteLine("Тест на палиндром\n\nВведите строку:");
            s = Console.ReadLine();
            s = s.Replace(" ", "");
            if (Palindromtest(s) == true)
                Console.WriteLine("Эта строка - палиндром");
            else Console.WriteLine("Эта строка - не палиндром");
            Console.ReadLine();
        }
    }
}
  

