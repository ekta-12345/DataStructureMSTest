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
            list.Add(56); // Adding data in list //UC9
            list.Add(30); // Adding data in list //UC9
            list.Add(40); // Adding data in list //UC9
            list.Add(70); // Adding data in list //UC9
            list.Display(); //call Display method to print data//UC9
            list.Count(); //call count method
            list.DeleteElement(40); //call DeleteElement method pass parameter // UC9     
            list.Display(); // Display //UC9
            list.Count(); //call count method and print count//UC9

            Console.ReadLine();



        }
    }
}

