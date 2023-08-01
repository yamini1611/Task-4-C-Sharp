using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public partial class Partial
    {
        partial void hashtable()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, " year old women" );
            ht.Add(2, 20);
            ht.Add(3, " is a ");
            ht.Add(4, "yamini");
      
            Console.WriteLine("HASHTABLE VALUES");
            foreach (DictionaryEntry item in ht)
            {
               
                Console.WriteLine("{0} : {1} ", item.Key, item.Value);
            }
           
        }

        partial  void hashset() {
            HashSet<string> set = new HashSet<string>();
            set.Add("vignesh ");
            set.Add("is a ");
            set.Add("lusu");
            Console.WriteLine("\n");
            Console.WriteLine("HASHSET VALUES");
            foreach (var a in set)
            {
               
                Console.WriteLine(a);
            }
        }

        partial void Queque()
        {
           Queue<string> q = new Queue<string>();
            q.Enqueue("bye");
            q.Enqueue("yamini");
            q.Enqueue("is ");
            q.Enqueue("hungry");
            q.Dequeue();
            Console.WriteLine("\n");
            Console.WriteLine("QUEUE VALUES");

        foreach (var a in q)
            {
                Console.WriteLine(a);
            }
        }

        partial void LinkedList()
        {
          LinkedList<string> ll = new LinkedList<string>();
            ll.AddFirst("harishmitha");
            ll.AddLast("harita");
            var n = ll.AddLast("ranita");
            ll.AddBefore(n, "viku");
            ll.AddAfter(n, "meena");
            Console.WriteLine("\n");
            Console.WriteLine("LINKED LIST VALUES ");
            foreach( var a in ll)
            {
                Console.WriteLine(a);
            }
        }
    }
} 
