using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peroperties1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee em=new Employee();
            em.Id = 21;
            Console.WriteLine("Your Employee id is : ");
            Console.WriteLine(em.Id);
            Console.ReadKey();
        }
    }
}
