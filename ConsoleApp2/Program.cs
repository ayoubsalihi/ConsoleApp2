using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> staff = new List<Employee>();

            staff.Add(new Developer("Alice", "Backend Dev", 10, 4500.0f));
            staff.Add(new Manager("Bob", "IT Manager", 5, 6000.0f));
            staff.Add(new Temporary("Charlie", "Freelancer", 50, 160));
            staff.Add(new Consultant("Khaled", "Consultant", "Audit financier", 3, 1500));

            foreach (var emp in staff)
            {
                emp.Afficher();
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
