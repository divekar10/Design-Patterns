using AbstractFactoryPattern.Features;
using AbstractFactoryPattern.Interface;

namespace AbstractFactoryPattern.Factory
{
    public class TataFactory : IVehicleFactory
    {
        public ICarEngine GetCarEngine()
        {
            return new Revtron();
        }

        public ICarLight GetCarLight()
        {
            return new Halogen();
        }
    }
}
