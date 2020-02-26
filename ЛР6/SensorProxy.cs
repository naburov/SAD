using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6
{
    class SmartHouseControllerProxy : SmartHouseController
    {
        public string ClientName;

        private SmartHouseController controller;
        List<string> logs = new List<string>();

        public List<string> Logs => logs;

        public override int Value
        {
            get
            {
                logs.Add(
                    String.Format("Клиент с именем {0} получил значение сенсора в {1}", ClientName, DateTime.Now));
                return controller.Value;
            }
            set
            {

                logs.Add(
                    String.Format("Клиент с именем {0} записал значение сенсора в {1}", ClientName, DateTime.Now));
                controller.Value = value;
            }
        }

        public SmartHouseControllerProxy(SmartHouseController controller)
        {
            this.controller = controller;
            controller.Value = 0;
        }

    }
}
