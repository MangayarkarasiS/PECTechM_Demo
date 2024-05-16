using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TechMPrg
{
    public abstract class Employe
    {
        protected string name;
        protected double salary;
        public Employe(string name, double salary)
        
        {
            this.name = name;
            this.salary = salary;
        }
        public void print()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Salary:" + salary);
        }
        
        
        public Employe() { }
    }

    public class Programmer : Employe,IIncrementable
    {
        public Programmer() { } 
        protected string domain;
        public Programmer(string domain)
        {
            this.domain = domain;
        }

        public Programmer(string name, double salary, string domain) : base(name, salary)

        {
            this.domain = domain;
        }
        public double Increment()
        {
            salary = (salary / 100) * 110;
            return salary;
        }

    }
    public class manager: Employe,IIncrementable
    {
        protected string teamid;
        public manager(string teamid)
        {
            this.teamid = teamid;
        }
        public void pprint()
        {
            base.print();
            Console.WriteLine(teamid);

        }

        public manager(string name, double salary, string teamid) : base(name, salary)
        {
            this.teamid = teamid;

        }
        public double Increment()
        {
            salary = (salary / 100) * 150;
            return salary;
        }
    }
    public interface IIncrementable
    { 
        public double Increment();
    }




}
        
    

