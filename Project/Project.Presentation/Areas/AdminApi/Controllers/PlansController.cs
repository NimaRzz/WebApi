using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Presentation.Areas.Admin.Models.DTOs.Plan;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Services.Plans.Commands.AddPlan;
using Project.Application.Services.Plans.Commands.UpdatePlan;
using Project.Domain.Entities.Offices;
using Project.Presentation.Areas.Admin.Models.DTOs.Common.Pagination;
using Project.Application.Services.Plans.Queries.GetPlans;
using Microsoft.AspNetCore.Authorization;

namespace Project.Presentation.Areas.Admin.Controllers
{
    //[Authorize("AdminOrOperator")]

    [Route("api/[controller]")]
    [ApiController]
    public class PlansController : ControllerBase
    {
        private readonly IPlanFacad _planFacad;

        public PlansController(IPlanFacad planFacad)
        {
            _planFacad = planFacad;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] PlanDto request)
        {
            var result = await _planFacad.AddPlanService.Execute(new RequestAddPlanDto()
            {
                Id = request.Id,
                Name = request.Name,
                Capacity = request.Capacity,
                StartPlan = request.StartPlan,
                EndPlan = request.EndPlan,
            });

            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] PlanDto request)
        {
            var result = await _planFacad.UpdatePlanService.Execute(new RequestUpdatePlanDto()
            {
                Id = request.Id,
                Name = request.Name,
                Capacity = request.Capacity,
                StartPlan = request.StartPlan,
                EndPlan = request.EndPlan,
            });

            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] string Id)
        {
            var result = await _planFacad.DeletePlanService.Execute(Id);
            return Ok(result);
        }

        [HttpPost("Get")]
        public async Task<IActionResult> Get([FromBody] string Id)
        {
            var result = await _planFacad.GetPlanService.Execute(Id);
            return Ok(result);
        }


        [HttpPost("GetAll")]
        public async Task<IActionResult> Get([FromBody] Pagination request)
        {
            var result = await _planFacad.GetPlansService.Execute(new RequestGetPlansDto()
            {
                Page = request.Page,
                PageSize = request.PageSize,
            });
            return Ok(result);
        }

    }
}