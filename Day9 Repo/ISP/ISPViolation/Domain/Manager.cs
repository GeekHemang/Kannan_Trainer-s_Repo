using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolation.Domain
{
    class Manager : IWorker
    {
        public void StartEat()
        {
            Console.WriteLine("manager starts eating");
        }

        public void StartWork()
        {
            Console.WriteLine("manager starts working");
        }

        public void StopEat()
        {
            Console.WriteLine("manager stop eating");
        }

        public void StopWork()
        {
            Console.WriteLine("manager stop working");
        }
    }
}
