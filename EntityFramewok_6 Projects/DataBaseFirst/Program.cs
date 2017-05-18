using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            TableContext();
           //AddingIntoTable().Wait();
        }

        private static void TableContext()
        {
            BetADOEntities context = new BetADOEntities();
           List<Student> list = context.Students.ToList();
            foreach (Student item in list)
            {
                Console.WriteLine($"{item.Id}, {item.FirstName}, {item.LastName}, {item.TimeStamp} ");
            }
        }

        private static async Task AddingIntoTable()
        {
            BetADOEntities context = new BetADOEntities();
            context.Students.Add(new Student{FirstName = "Poghas", LastName = "Petros"});
            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
            }
        }
    }
}
