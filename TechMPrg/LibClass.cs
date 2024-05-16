using System;
using TechMLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMPrg 
{

  abstract  class Employee
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public int basic_sal;
        public int HRA;
        public int med_all;

        public void EmpDetails()
        {
            Console.WriteLine("enter id and name of employee");
        }

         public abstract void CalcSal();
        
        
    }
    interface IPerformance
    {
        void Performance();
    }
    interface IBonus
    {
        int valuee { get; set; }
       
        public void Calc_Bonus();
        public void demo_meth()
        {
            Console.WriteLine(  "Demo method inside interface");
        }
        
    }

   
    class perm_Emp: Employee,IPerformance, IBonus
    {
        public int valuee { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void CalcSal()
        {
            int sal = basic_sal + HRA - med_all;
            Console.WriteLine(sal);
        }

        public void Calc_Bonus()
        {
            
        }

        public void Performance()
        {
            throw new NotImplementedException();
        }
    }
    class Con_Emp: Employee
    {
        public override void CalcSal()
        {
            int sal = basic_sal;
            Console.WriteLine(sal);
        }
    }
    class Tem_Emp:Employee
    {
       
        public int amount,hours;
        public override void CalcSal()
        {
            int sal = amount*hours;
            Console.WriteLine(sal);
        }


    }

    internal class LibClass:StuDetails
    {
        

        public void Display()
        {
            //Employee saran= new Employee();
            //saran.CalcSal();

            //Employee trainer= new Employee();
            //trainer.CalcSal();


            Meth_pro();
            StuDetails s=new StuDetails();
            s.Meth_pub();
           
            
        }
    }
    public class Game
    {
        public string Name { get; set; }
        public int MaxNumPlayers { get; set; }
        
        public override string ToString()
        {
           return ("Maximum number of players for " + Name + " is " + MaxNumPlayers);
        }
    }
    
    public class GameWithTimeLimit : Game
    {
        public int TimeLimit { get; set; }
        
        public override string ToString()
        {
             Console.WriteLine(base.ToString());
             return ("Time Limit for " + Name + " is " + TimeLimit + " minutes");
         }
    }
    
    /*public class Program
    {
        public static void Main(string[] args)
        {
                    Game g = new Game();
                   GameWithTimeLimit gt = new GameWithTimeLimit();
            
           Console.WriteLine("Enter a game");
                    g.Name = Console.ReadLine();
            
           Console.WriteLine("Enter the maximum number of players");
                     g.MaxNumPlayers = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter a game that has time limit");
                     gt.Name = Console.ReadLine();
            
            Console.WriteLine("Enter the maximum number of players");
                     gt.MaxNumPlayers = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the time limit in minutes");
                  gt.TimeLimit = int.Parse(Console.ReadLine());
   
            Console.WriteLine(g.ToString());
            Console.WriteLine(gt.ToString());
        }
    }*/
    
}
