using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public partial class Partial
    {

        partial void hashtable();
        partial void hashset();

        partial void Queque();

        partial void LinkedList();

    internal class Program
    {
         
            static void Main(string[] args)
            {
            Partial method = new Partial();
                method.hashtable();
                method.hashset();
                method.Queque();
                method.LinkedList();
                Console.ReadLine();
            }
        
        
    }
    }
}
