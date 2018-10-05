using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();
            Car car2 = car1;
            car2.Name = "Mercedes";

            Console.WriteLine(car1.Name);
            Console.Read();


        }
    }
}
