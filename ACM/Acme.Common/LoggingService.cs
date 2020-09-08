using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggable> itemsLog)
        {
            foreach (var item in itemsLog)
            {
                Console.Write(item.Log());
            }
        }
    }
}
