using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibraryV2.Model
{
    internal class AudiFactory : ICarFactory

    {
        public ICars MakeCar()
        {

            return new Audi();
        }
    }
}
