using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Common.Provinces;
using Project.Application.Interfaces.Offices;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Offices;
using Project.Domain.Repository.Office;
using Project.Application.Common.Pagination;
using Project.Application.Services.Offices.Commands.DTOs;

namespace Project.Application.Services.Offices.Queries.GetOffices
{
    public class GetOfficesService : IGetOfficesService
    {

        private readonly IOfficeRepository _repository;

        public GetOfficesService(IOfficeRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultDto<ResultGetOfficesDto>> Execute(RequestGetOfficesDto request)
        {

            var offices = await _repository.GetAll<Office>();

            if (offices.IsSuccess == false)
            {
                return new ResultDto<ResultGetOfficesDto>
                {
                    IsSuccess = false,
                    Message = "داده ای یافت نشد"
                };
            }

            int totalPages = 0;

            var officeQuery = offices.Data;

            var pagedResult = officeQuery.ToPaged(request.Page, request.PageSize, out totalPages);

            if (!string.IsNullOrEmpty(pagedResult.Message))
            {
                return new ResultDto<ResultGetOfficesDto>()
                {
                    IsSuccess = true,
                    Message = pagedResult.Message,
                    Data = new ResultGetOfficesDto()
                    {
                        TotalPages = totalPages,
                    }
                };
            }

            var officesList = pagedResult.Data.Select((p) => new GetOfficesDto
            {
                Id = p.Id,
                Name = p.Name,
                Address = p.Address,
                Province = Enum.GetName(typeof(ProvincesEnum), p.ProvinceId),

            }).ToList();

            return new ResultDto<ResultGetOfficesDto>()
            {
                Data = new ResultGetOfficesDto()
                {
                    Items = officesList,
                    TotalPages = totalPages
                },
                IsSuccess = true,
                Message = "لیست دفاتر با موفقیت دریافت شد"
            };
        }
    }
}