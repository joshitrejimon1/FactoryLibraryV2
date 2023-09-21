using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibraryV2.Model
{
    internal class BMW:ICars
    {
        public void Start()
        {
            Console.WriteLine("BMW IS STARTING");
        }

        public void Stop()
        {
            Console.WriteLine("BMW IS STARTING");
        }
    }
}
