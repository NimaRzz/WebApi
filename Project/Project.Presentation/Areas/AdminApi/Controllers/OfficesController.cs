using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Services.Offices.Commands.AddOffice;
using Project.Application.Services.Offices.Commands.AddPlanToOffice;
using Project.Application.Services.Offices.Commands.DeleteOfficePlan;
using Project.Application.Services.Offices.Commands.UpdateOffice;
using Project.Application.Services.Offices.Queries.GetOffices;
using Project.Domain.Entities.Offices;
using Project.Presentation.Areas.Admin.Models.DTOs.Common.Pagination;
using Project.Presentation.Areas.Admin.Models.DTOs.Office;
using Project.Presentation.Areas.Admin.Models.DTOs.OfficePlans;

namespace Project.Presentation.Areas.Admin.Controllers
{
    //[Authorize("Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class OfficesController : ControllerBase
    {
        
        private readonly IOfficeFacad _officeFacad;

        public OfficesController(IOfficeFacad officeFacad)
        {
            _officeFacad = officeFacad;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] AddOfficeDto request)
        {

            var result = await _officeFacad.AddOfficeService.Execute(new RequestAddOfficeDto()
            {
                Id = request.Id,
                Name = request.Name,
                ProvinceId = request.ProvinceId,
                Address = request.Address,
                Workdays = request.Workdays
               
            });
         

            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] OfficeDto request)
        {

            var result = await _officeFacad.UpdateOfficeService.Execute(new RequestUpdateOfficeDto()
            {
                Id = request.Id,
                Name = request.Name,
                Address = request.Address,
                Workdays = request.Workdays
            });

            return Ok(result);
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] string Id)
        {

            var result = await _officeFacad.DeleteOfficeService.Execute(Id);

            return Ok(result);
        }

        [HttpPost("Get")]
        public async Task<IActionResult> Get([FromBody] string Id)
        {

            var result = await _officeFacad.GetOfficeService.Execute(Id);

            return Ok(result);
        }

        [HttpPost("GetAll")]
        public async Task<IActionResult> Get([FromBody] Pagination request)
        {

            var result = await _officeFacad.GetOfficesService.Execute(new RequestGetOfficesDto
            {
                PageSize = request.PageSize,
                Page = request.Page,
            });

            return Ok(result);
        }

        [HttpPost("OfficeOptions-AddPlanToOffice")]
        public async Task<IActionResult> AddPlanToOffice([FromBody] OfficePlansDto request)
        {

            var result = await _officeFacad.AddPlanToOfficeService.Execute(new RequestAddPlanToOfficeDto
            {
                OfficeId = request.OfficeId,
                PlanId = request.PlanId,
            });

            return Ok(result);
        }

        [HttpPost("OfficeOptions-DeleteOfficePlan")]
        public async Task<IActionResult> DeleteOfficePlan([FromBody] OfficePlansDto request)
        {

            var result = await _officeFacad.DeleteOfficePlanService.Execute(new RequestDeleteOfficePlanDto
            {
                OfficeId = request.OfficeId,
                PlanId = request.PlanId,
            });

            return Ok(result);
        }

    }
}


