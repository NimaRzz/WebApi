using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Entities.Citizens;


namespace Project.Domain.Entities.Offices
{
    public class Office:BaseEntity.BaseEntity<string>
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public Province.Province Province { get; set; }

        public long ProvinceId { get; set; }

        public List<OfficePlan> OfficePlans { get; set; }

        public List<Citizen> Citizens { get; set; }
       
        public List<WorkCalendar> WorkCalendars { get; set; }


    }
}
