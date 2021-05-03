using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to data structure");
            LinkedList list = new LinkedList();

            list.InsertFront(70);
            list.InsertFront(30);
            list.InsertFront(56);
            //list.InsertFront(70);
            //list.InsertFront(56);

            //list.InsertAtParticularPosition(2, 30);
            //list.Display();
            //Console.ReadLine();

            //list.DeleteFirstNode();


            //list.DeleteLastNode();
            //list.Display();
            list.Search(30);
            Console.ReadLine();



        }
    }
}

