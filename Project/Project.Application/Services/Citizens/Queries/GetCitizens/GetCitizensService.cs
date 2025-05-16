using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Common.Pagination;
using Project.Application.Interfaces.Citizens;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Citizens;
using Project.Domain.Repository.Citizen;

namespace Project.Application.Services.Citizens.Queries.GetCitizens
{
    public class GetCitizensService:IGetCitizensService
    {

        private readonly ICitizenRepository _repository;

        public GetCitizensService(ICitizenRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto<ResultGetCitizensDto>> Execute(RequestGetCitizensDto request)
        {
            var citizens = await _repository.GetAll<Citizen>();

            if (citizens.IsSuccess == false)
            {
                return new ResultDto<ResultGetCitizensDto>
                {
                    IsSuccess = false,
                    Message = "داده ای یافت نشد"           
                };
            }

            int totalPages = 0;

            var citizenQuery = citizens.Data;

            var pagedResult = citizenQuery.ToPaged(request.Page, request.PageSize, out totalPages);

            if (!string.IsNullOrEmpty(pagedResult.Message))
            {
                return new ResultDto<ResultGetCitizensDto>
                {
                    IsSuccess = true,
                    Message = pagedResult.Message,
                    Data = new ResultGetCitizensDto
                    {
                        TotalPages = totalPages,
                    }
                };
            }

            var citizensList = pagedResult.Data.Select((p) => new GetCitizensDto
            {
                Id = p.Id,
                Name = p.Name,
                HouseholdCode = p.HouseholdCode,
                UniqueCode = p.UniqueCode,
                PassportCode = p.PassportCode,
                PersonalizedCode = p.PersonalizedCode

            }).ToList();

           return new ResultDto<ResultGetCitizensDto>
            {
                Data = new ResultGetCitizensDto
                {
                    Items = citizensList,
                    TotalPages = totalPages
                },
                IsSuccess = true,
                Message = "لیست اتباع با موفقیت دریافت شد"
            };
        }
    }
}
