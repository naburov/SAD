using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПАПС.AbstractFactory
{
    interface IScenarioFactory
    {
        ISensor CreateHumiditySensor();
        ISensor CreateTemperatureSensor();
        ISensor CreateIlluminationSensor();
        string GetPlace();
    }
}
