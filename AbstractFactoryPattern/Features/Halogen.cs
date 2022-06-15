using AbstractFactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Features
{
    public class Halogen : ICarLight
    {
        public string GetLightInfo()
        {
            return " Helogen Lights ";
        }
    }
}
