using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class watchwindow
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("enter value of a ");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of b ");
            int b =Convert.ToInt32(Console.ReadLine());
            watchwindow watchwindow = new watchwindow();
            int sum= watchwindow.add(a, b);
          
            Console.ReadLine();
        }

        public int add(int a,int b)
        {
            int result = a + b;
            return result;
          
        }
    }
}
