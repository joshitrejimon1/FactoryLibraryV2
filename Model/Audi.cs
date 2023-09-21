using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibraryV2.Model
{
    internal class Audi:ICars
    {
        public void Start()
        {
            Console.WriteLine("AUDI IS STARTING");
        }

        public void Stop()
        {
            Console.WriteLine("AUDI IS STARTING");
        }
    }
}
