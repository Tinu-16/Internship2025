using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Oct22
{
    internal class PushNotifier: INotificationService
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Dear {message}, your apponitment is fixed. Message using PushNotifier");
        }
    }
}
