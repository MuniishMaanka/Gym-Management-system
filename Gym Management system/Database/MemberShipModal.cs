using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_system.Database
{
    public class MemberShipModal
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DoB { get; set; }
        public string Tell { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public string City { get; set; }
        public string Village { get; set; }
        public string Em_Contact { get; set; }
        public string Emm_Name { get; set; }
        public string Emm_R { get; set; }
        public float Weigth { get; set; }
        public int PlansId { get; set; }
        

        public MemberShipModal(int id, string firstName, string lastName, string doB, string tell, string email, string sex, string city, string village, string em_Contact, string emm_Name, string emm_R, float weigth, int plansId )
        {
            this.id = id;
            FirstName = firstName;
            LastName = lastName;
            DoB = doB;
            Tell = tell;
            Email = email;
            Sex = sex;
            Weigth = weigth;
            City = city;
            Village = village;
            Em_Contact = em_Contact;
            Emm_Name = emm_Name;
            Emm_R = emm_R;
            Weigth = weigth;
            PlansId = plansId;
        }

    }
}
