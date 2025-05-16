using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Services.Citizens.Commands.AddCitizen;
using Project.Application.Services.Citizens.Commands.UpdateCitizen;
using Project.Application.Services.Citizens.Queries.GetCitizens;
using Project.Presentation.Areas.Admin.Models.DTOs.Citizen;
using Project.Presentation.Areas.Admin.Models.DTOs.Common.Pagination;


namespace Project.Presentation.Areas.AdminApi.Controllers
{
    //[Authorize("AdminOrOperator")]
    [Route("api/[controller]")]
    [ApiController]
    public class CitizensController : ControllerBase
    {
        private readonly ICitizenFacad _citizenFacad;
        public CitizensController(ICitizenFacad citizenFacad) 
        {
            _citizenFacad = citizenFacad;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CitizenDto request)
        {
            var result = await _citizenFacad.AddCitizenService.Execute(new RequestAddCitizenDto()
            {
                Name = request.Name,
                HouseholdCode = request.HouseholdCode,
                UniqueCode = request.UniqueCode,
                PassportCode = request.PassportCode,
                PersonalizedCode = request.PersonalizedCode
            });

            return Ok(result);
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateCitizenDto request)
        {
            var result = await _citizenFacad.UpdateCitizenService.Execute(new RequestUpdateCitizenDto()
            {
                Name = request.Name,
                Id = request.Id
            });

            return Ok(result);
        }
        
        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] long UniqueCode)
        {
            var result = await _citizenFacad.DeleteCitizenService.Execute(UniqueCode);
         

            return Ok(result);
        }

        [HttpPost("Get")]
        public async Task<IActionResult> Get([FromBody] long Id)
        {
            var result = await _citizenFacad.GetCitizenService.Execute(Id);

            return Ok(result);
        }

        [HttpPost("GetAll")]
        public async Task<IActionResult> Get([FromBody] Pagination request)
        {
            var result = await _citizenFacad.GetCitizensService.Execute(new RequestGetCitizensDto
            {
                PageSize = request.PageSize,
                Page = request.Page
            });
         

            return Ok(result);
        }

    }
}
