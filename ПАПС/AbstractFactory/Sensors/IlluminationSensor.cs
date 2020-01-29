using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПАПС.AbstractFactory
{

    class IlluminationSensor : ISensor
    {
        public SensorValues Value { get; set; } = 0;

        public string GetValue()
        {
            switch (Value)
            {
                case SensorValues.AboveNormal:
                    return "Освещенность выше нормы";

                case SensorValues.Normal:
                    return "Освещенность в норме";

                case SensorValues.BelowNormal:
                    return "Освещенность ниже нормы";
            }
            return "";
        }

        public IlluminationSensor() { }
    }
}
