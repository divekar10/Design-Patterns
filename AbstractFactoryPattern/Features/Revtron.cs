using AbstractFactoryPattern.Interface;

namespace AbstractFactoryPattern.Features
{
    public class Revtron : ICarEngine
    {
        public string GetEngineInfo()
        {
            return " Revtron engine for their diesal/petrol cars ";
        }
    }
}
