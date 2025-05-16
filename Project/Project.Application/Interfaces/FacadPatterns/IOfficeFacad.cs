using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Offices;

namespace Project.Application.Interfaces.FacadPatterns
{
    public interface IOfficeFacad
    {
        IAddOfficeService AddOfficeService { get; }

        IUpdateOfficeService UpdateOfficeService { get; }
    
        IDeleteOfficeService DeleteOfficeService { get; }
      
        IGetOfficeService GetOfficeService { get; }

        IGetOfficesService GetOfficesService { get; }

        IAddPlanToOfficeService AddPlanToOfficeService { get; }

        IDeleteOfficePlanService DeleteOfficePlanService { get; }


    }
}
