using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Common.Dto;
using CitizenModel = Project.Domain.Entities.Citizens.Citizen;
using Project.Domain.Repository.Citizen;
using Project.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Project.Application.Services.Citizens.Commands.DTOs;

namespace Project.Infra.Data.Repositories.Citizen
{
    public class CitizenRepository: BaseRepository.BaseRepository, ICitizenRepository
    {
        private readonly DataBaseContext _context;
       
        public CitizenRepository(DataBaseContext context):base(context) { 

        _context = context;

        }

        public async Task<ResultDto> GetCitizen(CitizenModel requestCode)
        {
           

            var citizen = await _context.Citizens.AsNoTracking().FirstOrDefaultAsync(p => p.HouseholdCode == requestCode.HouseholdCode 
                                                                                             || p.UniqueCode == requestCode.UniqueCode
                                                                                             || p.PassportCode == requestCode.PassportCode
                                                                                             || p.PersonalizedCode == requestCode.PersonalizedCode);
             if(citizen != null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "تبعه دیگری با یکی از کد هایه وارد شده وجود دارد"
                };
            }
            return new ResultDto
            {
                IsSuccess = true,
            };
        }
        
    }
}
