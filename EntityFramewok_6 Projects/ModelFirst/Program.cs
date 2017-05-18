using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ModelContainer dbcontainer = new ModelContainer())
            {
                dbcontainer.StudentInfoes.Add(new StudentInfo { FirstName = "A1", LastName = "A1yan", Age =27});
                dbcontainer.StudentInfoes.Add(new StudentInfo { FirstName = "A2", LastName = "A2yan", Age =25});
                dbcontainer.SaveChanges();

                var list = dbcontainer.StudentInfoes.ToList();
                foreach (StudentInfo item in list)
                {
                    Console.WriteLine($"{item.FirstName}, {item.LastName},{item.Age}");
                }
            }
           


        }
    }
}
