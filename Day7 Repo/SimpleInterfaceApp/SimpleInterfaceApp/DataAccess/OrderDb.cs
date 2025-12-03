using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.DataAccess
{
    internal class OrderDb : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("order create");
        }

        public void Delete()
        {
            Console.WriteLine("order delete");
        }

        public void Read()
        {
            Console.WriteLine("order read");
        }

        public void Update()
        {
            Console.WriteLine("order update");
        }
    }
}
