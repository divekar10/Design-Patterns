using AbstractFactoryPattern.Features;
using AbstractFactoryPattern.Interface;

namespace AbstractFactoryPattern.Factory
{
    public class MarutiFactory : IVehicleFactory
    {
        public ICarEngine GetCarEngine()
        {
            return new DDiS();
        }

        public ICarLight GetCarLight()
        {
            return new LED();
        }
    }
}
