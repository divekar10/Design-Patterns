using AbstractFactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factory
{
    public class LED : ICarLight
    {
        public string GetLightInfo()
        {
            return " Led Lights ";
        }
    }
}
