using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gym_Management_system.Schedules
{
    public class ScheduleModel
    {
       public string PlanName {get; set;}
       public string TimeIn {get; set;}
       public string TimeOut {get; set;}
       public string Trainer { get; set; }

       public ScheduleModel(string planName, string timeIn, string timeOut, string fullName)
        {
            PlanName = planName;
            TimeIn = timeIn;
            TimeOut = timeOut;
            Trainer = fullName;
        }
    }
}
