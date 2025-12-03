using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.DataAccess
{
     interface ICrudable
    {
        void Create();
        void Update();

        void Delete();
        void Read();
    }
}
