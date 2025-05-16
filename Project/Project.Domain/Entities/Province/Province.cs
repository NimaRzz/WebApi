using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Entities.Offices;

namespace Project.Domain.Entities.Province
{
    public class Province:BaseEntity.BaseEntity
    {

        public string Name { get; set; }

        public ICollection<Office> Offices { get; set; }
    }
}
