using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Client
    {
        private IVehicleFactory Factory = null;
        public void CreateCarWithLight(string carName)
        {
            carName = carName.ToLower();
            if (carName == "maruti")
            {
                Factory = new MarutiFactory();
                Console.WriteLine($"{carName} uses {Factory.GetCarEngine().GetEngineInfo()} with {Factory.GetCarLight().GetLightInfo()} as headlight.");
            }else if(carName.ToLower() == "tata")
            {
                Factory = new TataFactory();
                Console.WriteLine($"{carName} uses {Factory.GetCarEngine().GetEngineInfo()} with {Factory.GetCarLight().GetLightInfo()} as headlight.");
            }
            else
            {
                Console.WriteLine("sorry we dont have idea about this vehicle..");
            }
        }
    }
}
