using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibraryV2.Model
{
    internal class TeslaFactory : ICarFactory
    {
        public ICars MakeCar()
        {
         
            return new Tesla();
        }
    }
}
