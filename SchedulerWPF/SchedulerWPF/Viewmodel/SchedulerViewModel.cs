using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SchedulerWPF
{
    public class SchedulerViewModel
    {
        public ScheduleAppointmentCollection Events { get; set; }
        public SchedulerViewModel()
        {
            this.Events = new ScheduleAppointmentCollection();
            var scheduleAppointment = new ScheduleAppointment()
            {
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddHours(1),
                AppointmentBackground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF339933")),
                Subject = "Conference",
            };
            Events.Add(scheduleAppointment);
        }
    }
}
