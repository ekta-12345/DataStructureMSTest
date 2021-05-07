using System;

namespace DataStructure
{
    public class LinkedList
    {
        public Node head;
        public void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("inserted into list" + new_node.data);

        }
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void InsertFront(int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = this.head;
            this.head = new_node;
            Console.WriteLine("inserted into front" + new_node);
        }

        internal void Add(int v)
        {
            throw new NotImplementedException();
        }
                
        internal Node DeleteFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }

        public Node DeleteLastNode()
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                return null;
            }
            if (this.head.next == null)
            {
                this.head = null;
                return null;
            }
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return newNode;
        }
        public bool Search(int input)
        {
            bool flag = false;
            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == input)
                    {
                        Console.WriteLine("The element is present");
                        flag = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (!flag)
                    Console.WriteLine("The Element is Absent");
            }
            return flag;
        }
        public bool InsertAfter(int data, int after)
        {
            bool flag = false;
            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.data == after)
                    {
                        Node newNode = new Node(data);
                        newNode.next = temp.next;
                        temp.next = newNode;
                        flag = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (!flag)
                    Console.WriteLine("The Element is Absent");
            }
            return flag;
        }


        public void DeleteElement(int data)
        {
            bool flag = false;
            int count = 0;

            if (head == null)
                Console.WriteLine("List is Empty");
            else
            {
                Node temp = head;
                Node previousNode = null;
                while (temp != null)
                {

                    if (temp.data == data)
                    {
                        if (count == 1)
                        {
                            head = temp.next;
                        }
                        previousNode.next = temp.next;

                        flag = true;

                        break;
                    }
                    previousNode = temp;
                    temp = temp.next;

                }
                if (!flag)
                {
                    Console.WriteLine($"{data} Element Not Found in Linked List");
                }
                else
                {
                    Console.WriteLine($"Successfully Delete Element {data}");

                }
            }


            //return flag; 
        }

        public int Count()
        {
            int count = 0;

            Node temp = head;
            while (temp != null)
            {
                temp = temp.next;
                count++;
            }
            Console.WriteLine($"Linked List Count is {count}");

            return count;

        }


        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            else
            {
                while (temp.next != null)
                {
                    Console.Write(temp.data + "->");
                    temp = temp.next;
                }
                Console.WriteLine(temp.data);
            }
        }
    }

}
