using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities.Offices
{
    public class WorkCalendar:BaseEntity.BaseEntity
    {
        public DaysOfTheWeek Workday { get; set; }

        public TimeSpan WorkStart { get; set; }

        public TimeSpan WorkEnd { get; set; }

        public string OfficeId { get; set; }

        public Office Office { get; set; }
    }
}
