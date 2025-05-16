using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.FacadPatterns;
using Project.Domain.Repository.Plan;
using Project.Application.Interfaces.Plans;
using Project.Application.Services.Plans.Commands.AddPlan;
using Project.Application.Services.Plans.Commands.DeletePlan;
using Project.Application.Services.Plans.Commands.UpdatePlan;
using Project.Application.Services.Plans.Queries.GetPlans;
using Project.Application.Services.Plans.Queries.GetPlan;

namespace Project.Application.Services.Plans.FacadPattern
{
    public class PlanFacad:IPlanFacad
    {

        private readonly IPlanRepository _repository;

        public PlanFacad(IPlanRepository repository)
        {
            _repository = repository;
        }

        private IAddPlanService _addPlanService;

        public IAddPlanService AddPlanService
        {
            get
            {
                return _addPlanService = _addPlanService ?? new AddPlanService(_repository);
            }
        }

        private IUpdatePlanService _updatePlanService;

        public IUpdatePlanService UpdatePlanService
        {
            get
            {
                return _updatePlanService = _updatePlanService ?? new UpdatePlanService(_repository);
            }
        }

        private IDeletePlanService _deletePlanService;

        public IDeletePlanService DeletePlanService
        {
            get
            {
                return _deletePlanService = _deletePlanService ?? new DeletePlanService(_repository);
            }
        }


        private IGetPlanService _getPlanService;

        public IGetPlanService GetPlanService
        {
            get
            {
                return _getPlanService = _getPlanService ?? new GetPlanService(_repository);
            }
        }


        private IGetPlansService _getPlansService;

        public IGetPlansService GetPlansService
        {
            get
            {
                return _getPlansService = _getPlansService ?? new GetPlansService(_repository);
            }
        }

    }
}
