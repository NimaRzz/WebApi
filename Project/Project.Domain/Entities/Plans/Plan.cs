using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Entities.Appointments;
using Project.Domain.Entities.Offices;


namespace Project.Domain.Entities.Plans
{
    public class Plan:BaseEntity.BaseEntity<string>
    {
        
        public int Capacity { get; set; }

        public string Name { get; set; }

        public DateTime StartPlan { get; set; }
      
        public DateTime EndPlan { get; set; }

        public ICollection<OfficePlan> OfficePlans { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

    }
}
