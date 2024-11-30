using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_system.Database
{
    public class AttendanceModal
    {
        // att.customer_id,
        // cus.firstname || ' ' || cus.lastname AS full_name,
        // att.AttDate,
        // att.attendanced,
        // pl.plan_name
        
        public int Customer_id { get; set; }
        public string Fullname { get; set; }
        public string Date { get; set; }
        public bool Attended { get; set; }

        public AttendanceModal(int customer_id, string fullname, string date, bool attendanced )
        {
            Fullname = fullname;
            Customer_id = customer_id;
            Date = date;
            Attended = attendanced;
        }

    }
}
