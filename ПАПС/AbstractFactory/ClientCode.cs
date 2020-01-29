using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПАПС.AbstractFactory
{
    class ClientCode
    {
        public ISensor HumiditySensor { get; set; }
        public string Place { get; set; }

        public ClientCode(IScenarioFactory factory)
        {
            HumiditySensor = factory.CreateHumiditySensor();
            Place = factory.GetPlace();
        }

    }
}
