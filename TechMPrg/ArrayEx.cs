using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMPrg
{
    internal class ArrayEx
    {
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
            //perAge[0] = 25;
            //perAge[1] = 35;
            //perAge[2] = 45;


            //int ageValue = perAge[1];

            //Console.WriteLine(perAge[2]);
            int[] perAge = new int[5];

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
            }

        }
        public void TwoDimension()
        {
            int[,] twodim = new int[2, 3];
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







        }



    }
}
