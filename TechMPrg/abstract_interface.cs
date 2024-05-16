using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMPrg
{
    internal class abstract_interface
    {
    }

    interface IBonuss
    {
        public void calc_Bonus();

    }

    public class demoClass : IBonuss
    {
        public void calc_Bonus()
        {
            float calculated_amount = 50000f * 0.1f;
            Console.WriteLine("Bonus Amount="+calculated_amount);
        }
    }


}
