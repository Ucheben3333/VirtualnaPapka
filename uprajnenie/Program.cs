using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace uprajnenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> mylist = new LinkedList<string>();

            mylist.AddLast("Ivo");

            LinkedListNode<string> newNode = mylist.AddLast("Petar");
            mylist.AddAfter(newNode, "Ivan");
            mylist.AddBefore(newNode, "Georgi");
            foreach (string item in mylist)
            {
                Console.WriteLine(item);
            }
            
            LinkedListNode<string> Nodelist = mylist.Last;
            while (Nodelist != null)
            {
                Console.WriteLine(Nodelist.Value);
                Nodelist = Nodelist.Previous;
            }
          
        }
    }
}
