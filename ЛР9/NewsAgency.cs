using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ЛР9.interfaces;

namespace ЛР9
{
    class NewsAgency:IObservable
    {
        List<IObserver> Observers { get; set; }

        public void AddObserver(IObserver o)
        {
            Observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            Observers.Remove(o);
        }

        public void SendNews()
        {
            int newsCount = 0;
            foreach (var observer in Observers)
                observer.ReceiveNews(String.Format("Получена новость {0}", newsCount++));
        }        
    }
}
