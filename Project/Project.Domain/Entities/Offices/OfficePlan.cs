using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Entities.Plans;

namespace Project.Domain.Entities.Offices
{
    public class OfficePlan:BaseEntity.BaseEntity
    {


        public Office Office { get; set; }

        public string OfficeId { get; set; }

        public Plan Plan { get; set; }

        public string PlanId { get; set; }


    }
}
