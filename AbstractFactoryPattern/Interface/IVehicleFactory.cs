using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Interface
{
    public interface IVehicleFactory
    {
        ICarLight GetCarLight();
        ICarEngine GetCarEngine();
    }
}
