using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПАПС.AbstractFactory
{
    public enum SensorValues { Normal, AboveNormal, BelowNormal}

    class HumiditySensor : ISensor
    {
        public SensorValues Value { get; set; }

        public string GetValue()
        {
            switch (Value)
            {
                case SensorValues.AboveNormal:
                    return "Влажность выше нормы";

                case SensorValues.Normal:
                    return "Влажность в норме";

                case SensorValues.BelowNormal:
                    return "Влажность ниже нормы";
            }
            return "";
        }

        public HumiditySensor() { }
    }
}
