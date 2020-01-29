using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПАПС.AbstractFactory
{
    class LowHumidityScenario:IScenarioFactory
    {
        string place;

        public string GetPlace() => place;

        public ISensor CreateHumiditySensor()
        {
            var HSensor = new HumiditySensor();
            HSensor.Value = SensorValues.BelowNormal;
            return HSensor;
        }

        public ISensor CreateTemperatureSensor()
        {
            var TSensor = new TemperatureSensor();
            TSensor.Value = SensorValues.Normal;
            return TSensor;
        }

        public ISensor CreateIlluminationSensor()
        {
            var IlluminationSensor = new IlluminationSensor();
            IlluminationSensor.Value = SensorValues.Normal;
            return IlluminationSensor;
        }

        public LowHumidityScenario(string place)
        {
            this.place = place;
        }
    }
}
