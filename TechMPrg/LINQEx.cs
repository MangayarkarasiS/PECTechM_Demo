using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechMPrg
{
    public class color
    {
        public int colorId { get; set; }
        public string colors { get; set; }
    }

    internal class LINQEx
    {       

        public void ArrIteration()
        {
            string[] colors = { "Red", "Blue", "Green", "Yellow", "Black", "Brown" };

            //query syntax
            var str=  from c in colors
                        where c.Length>3 && c.StartsWith('B') 
                        orderby c
                        select c;

            //method syntax
              var str1 = colors.Where(c=>c.Length > 3 && c.StartsWith('B')).OrderBy(c=>c).Select(c=>c);
            var str2 = colors.Where(c => c.Contains('e')).Select(c=>c);

            foreach (var c in str2)
            {
                Console.WriteLine($"Colors : {c}");
            }
             
             
        }
        public void ListIteration()
        {
            List<string> listColor = new List<string>() { "Red", "Blue", "Green", "Yellow", "Black", "Brown" };

            var str = from c in listColor
                      where c.Length > 3 && c.StartsWith('B')
                      orderby c
                      select c;

            foreach (var c in str)
            {
                Console.WriteLine($"Colors : {c}");
            }


        }
        public void ClassIteration()
        {
           color c=new color();
            c.colorId = 100;
            c.colors = "Red";

            color c1 = new color();
            c1.colorId = 101;
            c1.colors = "Blue";

            color c2 = new color();
            c2.colorId = 102;
            c2.colors = "Green";

            color c3 = new color();
            c3.colorId = 103;
            c3.colors = "Black";

            List<color> colors = new List<color>();
            colors.Add(c);
            colors.Add(c1);
            colors.Add(c2);
            colors.Add(c3);    


            var str = from obj in colors
                      where obj.colors.Length > 3 && obj.colors.StartsWith('B')
                      orderby obj.colors
                      select obj.colors;
            // var str1 = colors.Where(c => c.Length > 3 && c.StartsWith('B')).OrderBy(c => c).Select(c => c);

            var str2 = colors.Where(obj => obj.colors.Length > 3 && obj.colors.StartsWith('B'))
                           .OrderBy(obj => obj.colors)
                           .Select(obj => obj);

            foreach (var o1 in str2)
            {
                Console.WriteLine($"ColorId : {o1.colorId}, colorNm :{o1.colors}");
            }


            //var str2 = colors.Where(obj => obj.colors.Length > 3 && obj.colors.StartsWith('B'))
            //               .OrderBy(obj => obj.colors)
            //               .Select(obj=> new { id = obj.colorId, name = obj.colors });

            //foreach (var o1 in str2)
            //{
            //    Console.WriteLine(o1.id);
            //    Console.WriteLine(o1.name);
            //    //// Console.WriteLine($"ColorId : {o1.colorId}, colorNm :{o1.colors}");
            //}


        }
        public static void LGroupby()
        {
            // select count(*),dept_name,gender from dept groupby dept_name,gender
            // IT  4
            //HR    5

            //var employeeGroup = from employee in Employee.GetAllEmployees()
            //                    group employee by new { employee.Department, employee.Gender }
            //                    ;

            //foreach (var group in employeeGroup)
            //{
            //    Console.WriteLine("{0} - {1}", group.Key, group.Count());
            //}
        }

    }
}
