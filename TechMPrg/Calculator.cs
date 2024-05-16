using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMPrg
{
    class Prod
    {
        public static float Prod_price = 15.25f;
        public double price = 25.25f;

        public static void cacl_Price()
        {
           // double pr = price * 2;
        }

        public void TestStaticPrice()
        {
            float prdPrice = Prod_price * 2;
        }
    }



    public class Calculator
    {
        public int add(string num1,int num2)
        {
            Prod p=new Prod();
            p.TestStaticPrice();

            Console.WriteLine(Prod.Prod_price);
            return 0;
        }
        public int add(int num1, string num2)
        {
            int res = num1 + 5;
            return res;
        }
        public virtual int sub(int num1, int num2)
        {
            int res = num2 - num1;
            return res;
        }

        //no.of parameters
        //datatype of parameters
        //order of parameters
    }
    public class sum:Calculator { 
        public override int sub(int num1, int num2)
        {
            int res = num2 - num1 * 10;
            return res;
        }
    
    }
}
