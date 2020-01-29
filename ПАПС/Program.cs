using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ПАПС.AbstractFactory;

namespace ПАПС
{
    class Program
    {
        static void Main(string[] args)
        {
            LowHumidityScenario lowHumidityScenarioFactory = new LowHumidityScenario("Кухня");
            StandardScenario standardFactory = new StandardScenario("Гостинная");

            ClientCode kitchenCode = new ClientCode(lowHumidityScenarioFactory);
            Console.WriteLine(kitchenCode.HumiditySensor.GetValue());

            ClientCode livingRoomCode = new ClientCode(standardFactory);
            Console.WriteLine(livingRoomCode.HumiditySensor.GetValue());
        }
    }
}
