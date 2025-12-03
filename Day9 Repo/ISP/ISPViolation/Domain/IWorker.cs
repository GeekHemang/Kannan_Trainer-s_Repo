using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolation.Domain
{
    interface IWorker
    {
        void StartWork();
        void StopWork();
        void StopEat();
        void StartEat();

    }
}
