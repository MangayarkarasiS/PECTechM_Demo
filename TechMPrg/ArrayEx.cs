using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TechMPrg
{
    internal class ArrayEx
    {

        private int price;
        

        public int _price
        {
            get { return price; }
            set
            {
                if (value > 0 && value < 50)
                {
                    price = value;
                }
                else
                { 
                price = 0;
                }
            }
        }


        int values = 10;

        public  int[] val = { 10, 20, 30, 40, 50 };
        double[] val2 =new double[] { 10, 20, };
        float[] floats = { 1.25F,3,46F};
        string[] strs = { "john", "peter", "Mandy" };
       

        public void printValues( int[] val)
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }

        public void AcceptValues()
        {
            Console.WriteLine("Enter Value of Price");
            _price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entered value "+_price);

            //perAge[0] = 25;
            //perAge[1] = 35;
            //perAge[2] = 45;


            //int ageValue = perAge[1];

            //Console.WriteLine(perAge[2]);
            /*   int[] perAge = new int[5];

               for (int i=0;i<perAge.Length;i++)
               {
                   Console.WriteLine("Enter age of person {0} : ",i+1);
                   perAge[i]=Convert.ToInt32(Console.ReadLine());
               }


               Console.WriteLine(  "Values from Original array");
               for (int i = 0; i < 5; i++)
               {
                   Console.WriteLine("Age of Person {0} is {1} ", i+1, perAge[i]);

               }
               Array.Sort(perAge);

               Console.WriteLine("Values from sorted array");
               foreach (int age in perAge)
               {
                   Console.WriteLine(  age);
               }*/

        }
        public void TwoDimension()
        {
            int[,] twodim = new int[2, 3] { { 1, 2, 3 } ,{ 2, 3, 4 } };
            twodim[0, 0] = 1;
            twodim[1, 0]= 2;
            twodim[0,1] = 3; 

            for(int i=0;i<2;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.WriteLine("Enter value of array {0},{1}", i, j);
                    twodim[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine(  "Output matrix");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // Console.WriteLine("array value {0},{1}, {2}", i, j, twodim[i,j]);
                    Console.Write(twodim[i,j]+"\t");

                }
                Console.WriteLine(  );
            }

        }

        public void switchCa()
        {
            int getitem = 8;
           
            switch (getitem)
            {

                case 2:
                    Console.WriteLine("Red");
                    break;

                case 4:
                    Console.WriteLine("Blue");

                    break;
                case 6:
                    Console.WriteLine("Green");
                    break;

                case 8:
                    Console.WriteLine("White");
                    break;

                case 10:
                    Console.WriteLine("Red");
                    break;

                default:
                    Console.WriteLine("No greeting found");
                    break;



            }
        }

        public void c8switchcase()
        {
            var getitem = 4;

            var res = getitem switch
            {
                2 => "Red", 
                4 => "Blue",
                6 => "Green",
                8 => "White",
                _ => "No colour found",

            };

            Console.WriteLine(res);
        }
        
        public void jaggedArray()
        {
            int[] price = new int[2];
            int[][] jagarr= new int[2][];

            price[0] = 10;
            price[1] = 20;

            jagarr[0]=new int[3];
            jagarr[1] = new int[4]; 


            for(int i=0;i<jagarr.Length;i++)
            {
                Console.WriteLine("Enter value of {0} array",i +1 );
                for (int j = 0; j < jagarr[i].Length;j++)
                {
                    Console.WriteLine("Get value of array"  );
                    jagarr[i][j]=Convert.ToInt32(Console.ReadLine());

                }
            }

            for (int i = 0; i < jagarr.Length; i++)
            {
                Console.WriteLine("Print value of {0} array", i + 1);
                for (int j = 0; j < jagarr[i].Length; j++)
                {
                    Console.WriteLine("Printing value of array " + jagarr[i][j]);
                   

                }
            }

            
            {

            }







        }
        float[] Prices = new float[2];
        public void Price()
        {
            //Prices = float.Parse(Console.ReadLine());
            for(int i=0;i< Prices.Length;i++)
            {
                Prices[i] = float.Parse(Console.ReadLine());
            }
            int j = 0;
            do
            {
                Console.WriteLine(Prices[j]);
                j++;
            }
            while (Prices[j] < 25 && j < Prices.Length);
        }

    }
}
