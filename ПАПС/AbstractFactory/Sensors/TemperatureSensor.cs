using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПАПС.AbstractFactory
{

    class TemperatureSensor : ISensor
    {
        public SensorValues Value { get; set; } = 0;

        public string GetValue()
        {
            switch (Value)
            {
                case SensorValues.AboveNormal:
                    return "Температура выше нормы";

                case SensorValues.Normal:
                    return "Температура в норме";

                case SensorValues.BelowNormal:
                    return "Температура ниже нормы";
            }
            return "";
        }

        public TemperatureSensor() { }
    }

}
