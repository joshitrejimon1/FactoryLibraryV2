using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibraryV2.Model
{
    internal class Tesla : ICars
    {
        public void Start()
        {
            Console.WriteLine("TESLA IS STARTING");
        }

        public void Stop()
        {
            Console.WriteLine("TESLA IS STARTING");
        }
    }
}
