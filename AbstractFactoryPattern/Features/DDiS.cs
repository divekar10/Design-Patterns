using AbstractFactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Features
{
    public class DDiS : ICarEngine
    {
        public string GetEngineInfo()
        {
            return " DDis engine for their diesal cars ";
        }
    }
}
