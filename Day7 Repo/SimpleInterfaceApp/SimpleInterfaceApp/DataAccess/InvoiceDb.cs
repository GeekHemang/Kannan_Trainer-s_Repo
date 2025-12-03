using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.DataAccess
{
    internal class InvoiceDb : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("invoice create");
        }

        public void Delete()
        {
            Console.WriteLine("invoice delete");
        }

        public void Read()
        {
            Console.WriteLine("invoice read");
        }

        public void Update()
        {
            Console.WriteLine("invoice update");
        }
    }
}
