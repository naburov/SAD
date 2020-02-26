using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ЛР9.interfaces;

namespace ЛР9
{
    class NewsSubscriber : IObserver
    {
        List<string> News { get; set; }

        public void ReceiveNews(string news)
        {
            News.Add(news);
        }

        public NewsSubscriber()
        {
            News = new List<string>();
        }        
    }
}
