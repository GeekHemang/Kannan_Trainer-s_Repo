using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPRefactored.Domain
{
    class Robot : ICanDoWork
    {
        public void StartEat() //false promise
        {
            throw new Exception("Robots dont eat");
        }

        public void StopEat() //false promise
        {
            throw new Exception("Robots dont eat");
        }

        public void StartWork()
        {
            Console.WriteLine("Robot starts working");
        }



        public void StopWork()
        {
            Console.WriteLine("Robot stops working");
        }
    }
}
