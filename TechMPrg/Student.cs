using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMPrg
{
    public enum Gender
    {
        Male,
        Female,
        Others
    }

    public class admin
    {
        public string Name { get; set; }
        public int age;
       
        public void Enumex()
        {
            Console.WriteLine("Enter age of person");
            age=int.Parse( Console.ReadLine());
           
            Gender gen;

            //Console.WriteLine("Enter the gender of person");
            //gen=(Gender)Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Entered value="+gen);

            Console.WriteLine("Enter the gender of person");
            gen=(Gender)Enum.Parse(typeof(Gender), Console.ReadLine());
            Console.WriteLine("Entered value=" + gen);

            PrintGender(10,gen);
        }

        public void PrintGender(int age,Gender gen)
        {
            if(age<=10 )
                Console.WriteLine("He's a Kid");
            if (gen == 0)
                Console.WriteLine("He belongs to West wing");
            if (gen == Gender.Male) 
                Console.WriteLine("He belongs to East wing");


        }

        public void get()
        {
            int a = 5;
            int rest = 6;
            sqroot(a, ref  rest);
            Console.WriteLine(  "initial value of  number={0}, sqroot of number={1}",a,rest);

        }
        public void sqroot(int a,ref int rest)
        {           
            rest= a * a;
           // return a;
        
        }







        //out parameter
      public   void OutParam()
            {
            int a = 5;
             CubeRoot(a,  out int result);
            Console.WriteLine("Cube root of a={0} is ={1}: " ,a, result); 
            }
            public void CubeRoot(int a, out int result)
            {
                result = a * a * a;
            }
        //ref parameter
        public void refParam()
        {
            int a =100, b = 90;
            Console.WriteLine(  "Value of a={0}, b={1}",a,b);
           int b1= CubeRoot1(ref a, b);
            Console.WriteLine("Value after Cube root of a={0}  is b ={1}: ", a, b1);
        }
        public int CubeRoot1(ref int a, int b)
        {
            a= a * a * a;
            b = b * b * b;
            return (b);
        }


        public admin() {
          
        }
        public admin(string Name)
        {
           this.Name = Name;
        }
        public void show()
        {
            string design = "HR";
            Console.WriteLine("Name= " + Name);
            //return design;
        }
        public void display()
        {
            Console.WriteLine("Name= "+Name  );
        }
       
       /* public void EnumEx()
        {
            Gender gen;
            gen = (Gender) (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Gender of person=" + gen);

            color c;
            Console.WriteLine("enter the color you want");
            c=(color) Enum.Parse(typeof(color), Console.ReadLine());

            Console.WriteLine("Color entered="+c);
        }*/
       



    }

    internal class Student
    {
        public int studId { get; set; }
        public string studName { get; set; }
        public double price { get; set; }
        public sbyte price1 { get; set; }
        public void getDetails()
         {             
            
             Console.WriteLine("Enter student Id :" );
             studId=Convert.ToInt32( Console.ReadLine());
            
            Console.WriteLine(  "enter price");
            price= Convert.ToDouble( Console.ReadLine());

            Console.WriteLine("Enter student Name :");
            studName = Console.ReadLine();
          
            }
        public void PrintDetails()
        {
            Console.WriteLine("Id={0}, student Name ={1} , Price={2}", studId, studName, price);

        }
    }
}
