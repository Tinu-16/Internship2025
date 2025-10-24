using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Oct22
{
    public class AppointmentService
    {
        private readonly INotificationService _notificationService;

        public AppointmentService(INotificationService notificationService)
        {
            _notificationService= notificationService;
        }

        public void AppointmentNotify(string name)
        {
            _notificationService.Notify(name);
        }
    }
}
