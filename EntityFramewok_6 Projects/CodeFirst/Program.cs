using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Model context = new Model();
           var list = context.StudentInfos.ToList();
            foreach (StudentInfo item in list)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}, {item.Age}");
            }
        }
    }
}
