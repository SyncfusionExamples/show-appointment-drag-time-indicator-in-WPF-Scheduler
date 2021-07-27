using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SchedulerWPF
{
    public class ScheduleBehavior : Behavior<Grid>
    {
        Grid grid;
        SfScheduler schedule;
        protected override void OnAttached()
        {
            grid = this.AssociatedObject as Grid;
            schedule = grid.Children[0] as SfScheduler;
            schedule.AppointmentDragOver += OnScheduleAppointmentDragOver;
        }

        private void OnScheduleAppointmentDragOver(object sender, AppointmentDragOverEventArgs e)
        {
            if (e.DraggingTime.Minute == 30 || e.DraggingTime.Minute == 00)
            {
                schedule.DragDropSettings.ShowTimeIndicator = true;
            }
            else
                schedule.DragDropSettings.ShowTimeIndicator = false;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            schedule.AppointmentDragOver -= OnScheduleAppointmentDragOver;
            grid = null;
            schedule = null;
        }
    }
}
