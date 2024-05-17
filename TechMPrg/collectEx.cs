using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using TechMLib;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TechMPrg
{
   
    class order
    {
        public int orderId;
        public string orderName;
    }

    internal static class collectEx
    {
        public static Stack<string> stackPlate=new Stack<string>();

        public static void AddPlate()
        {
            
            stackPlate.Push("Plate1");
            stackPlate.Push("Plate2");
            stackPlate.Push("Plate3");

        }

        /*customer portal
         Welcome to Online Food Delivery system
           
        Select the food you want to order

        1. Juice
        2. IceCream
        3. Sweets
        4. Dosa

        Admin portal :

        What do you want to do?
        1. Add food items
        2. Delete food items
        3. Change food items
        4. Display food items

        Dosa 25 - ditionary
        -------------------------------------------------------

        class food
        {
        id,name,price,hotel
        }

        dictionary<string, food>
























         
         
         
         
         
         */







        public static void RemovePlate()
        {
            stackPlate.Pop();
        }

        public static void DisplayPlate()
        {
            foreach (var item in stackPlate)
            {
                Console.WriteLine(item);
            }
        }







        public static void stackEx()
        {
            Stack s= new Stack();
            s.Push(1);
            s.Push("rainbow");
            s.Push(25.25M);

            Console.WriteLine("Stack values");
            foreach (var k in s)
            {
                Console.WriteLine(k);
            }

            s.Pop();

            Console.WriteLine("Stack values after poping");
            foreach (var ki in s)
            {
                Console.WriteLine(ki);
            }

            Stack<char> stack = new Stack<char>();
            stack.Push('d');

            Queue q = new Queue();
            q.Enqueue("good");
            q.Enqueue("better");
            q.Enqueue("best");

            Console.WriteLine("after addition in queue");
            foreach (var qi in q)
            {
                Console.WriteLine(qi);
            }

            q.Dequeue();
            Console.WriteLine("after deleting in queue");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            {

            }



        }

        public static void ArrLst()
        {
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add("Goodbye");
            array.Add(25.25f);
            array.Add(25);
            array.Add("Hello");

            foreach(var arr in array)
            {
                Console.WriteLine("ArrayList="+arr);
            }

            array.RemoveAt(3);

            foreach (var arr in array)
            {
                Console.WriteLine("after removing :"+arr);
            }

            array.Insert(3, 80);

            foreach (var arr in array)
            {
                Console.WriteLine("Inserted element  :"+arr);
            }

        }
 public static void ListArr()
        {
            order o1=new order();
            o1.orderId = 100;
            o1.orderName = "FristOrder";

            order o2 = new order();
            o2.orderId = 200;
            o2.orderName = "secondOrder";

            List<order> Orderlist=new List<order>();
            Orderlist.Add(o1);
            Orderlist.Add(o2);
            Orderlist.Add(new order{ orderId=25,orderName="thirdorder"});

            foreach (order o in Orderlist)
            {
                Console.WriteLine("ID={0},  Name={1}",o.orderId,o.orderName);
            }
                      

            List<string>  strlst=new List<string>();
            strlst.Add("names");

            List<int> list = new List<int>();
            //adding element to list
            list.Add(1);
            list.Add(2);            
            list.Add(3);
            list.Add(4);

            Console.WriteLine("Addition operation");
            foreach (int arr in list)
            {
                Console.WriteLine( arr);
            }

            Console.WriteLine("search operation");
            //searching
            if (list.Contains(2))
                Console.WriteLine("Element found");
            else
                Console.WriteLine("Element not found");

            Console.WriteLine("Delete operation");
            //remove

            list.Remove(3);
            foreach (int arr in list)
            {
                Console.WriteLine(arr);
            }

            Console.WriteLine("Updation operation");
            //updation
            list[1] = 255;
            foreach (int arr in list)
            {
                Console.WriteLine(arr);
            }

        }
        public static void HashTab()
        {
            Hashtable ht = new Hashtable();
            ht.Add(10, "Hello");
            ht.Add(25.25f, "FloatValue");
            ht.Add("stringvalue", "2ndvalue");

            foreach (DictionaryEntry arr in ht)
            {
                Console.WriteLine("Key={0}, value={1}", arr.Key, arr.Value);
            }

            if (ht.ContainsKey(25.25f))
                Console.WriteLine(ht[25.25f]);

            Dictionary<int, string> dc = new Dictionary<int, string>();
            dc.Add(1, "one");
            dc.Add(2, "two");

            foreach (KeyValuePair<int, string> arr in dc)
            {
                Console.WriteLine(arr.Key);
                Console.WriteLine(arr.Value);
            }

            Dictionary<int, order> dco = new Dictionary<int, order>();
            dco.Add(1, new order { orderId = 500, orderName = "books" });
            dco.Add(2, new order { orderId = 510, orderName = "products" });

            foreach (KeyValuePair<int, order> arr in dco)
            {
                Console.WriteLine(arr.Value.orderName);
            }

             List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);

            Dictionary<string, List<int>> valuePairs = new Dictionary<string, List<int>>();
            valuePairs.Add("red",list);
            valuePairs.Add("Blue",new List<int> { 12, 14 ,12 ,56 } );

            foreach (KeyValuePair<string,List<int>> item in valuePairs)
            {
                foreach (int val in item.Value)
                {
                    Console.WriteLine(val);
                }
            }



        }


        public static void player1()
        {
            //Assignment 1
            List<string> ven = new List<string>();

            Console.WriteLine("Enter number of matches played by CSK.");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter venue information");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("enter venue : {0}", j + 1);
                string venn = Console.ReadLine();
                ven.Add(venn);
            }

            Console.WriteLine("enter the venue that needs to be counted");
            string v = Console.ReadLine();
            int cnt = 0;
            foreach (string venn in ven)
            {
                if (v == venn)
                { cnt++; }
            }

            Console.WriteLine("Count of matches played in {0} venue ={1}", v, cnt);


            //assignment 2
            /*  Console.WriteLine("Enter no.of matches played by csk");
              int n = Convert.ToInt32(Console.ReadLine());

              List<int> lst=new List<int>();
              int sum = 0;

              for (int i = 0; i < n; i++)
              {
                  Console.WriteLine("Enter scores played in match {0} :",i+1);
                  lst.Add(Convert.ToInt32(Console.ReadLine()));  
              }

              foreach (int i in lst)
              {
                  sum = sum + i; 
              }

              int avg=sum/lst.Count;

              Console.WriteLine("Total scores :"+sum);
              Console.WriteLine("Averg acores :" + avg);
            */
        }














    }
}
