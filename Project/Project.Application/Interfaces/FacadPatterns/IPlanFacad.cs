using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Plans;

namespace Project.Application.Interfaces.FacadPatterns
{
    public interface IPlanFacad
    {
        IAddPlanService AddPlanService { get; }

        IUpdatePlanService UpdatePlanService { get; }
      
        IDeletePlanService DeletePlanService { get; }

        IGetPlanService GetPlanService { get; }
      
        IGetPlansService GetPlansService { get; }
    }
}
