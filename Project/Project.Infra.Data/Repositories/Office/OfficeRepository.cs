using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Province;
using Project.Domain.Repository.BaseRepository;
using Project.Domain.Repository.Office;
using Project.Infra.Data.Contexts;
using Project.Domain.Entities.Offices;

namespace Project.Infra.Data.Repositories.Office
{
    public class OfficeRepository: BaseRepository.BaseRepository, IOfficeRepository
    {
        private readonly DataBaseContext _context;

        public OfficeRepository(DataBaseContext context):base(context)
        {
            _context = context;
        }

        public async Task<List<WorkCalendar>> GetAllWorkCalendarsAsync(string OfficeId)
        {
          return await _context.WorkCalendars.Where(p => p.OfficeId == OfficeId).ToListAsync();
        }

        public async Task<ResultDto<OfficePlan>> GetOfficePlan(string OfficeId, string PlanId)
        {
           var officePlan =  await _context.OfficePlans.AsNoTracking().FirstOrDefaultAsync(p => p.OfficeId == OfficeId && p.PlanId == PlanId);

            if(officePlan == null)
            {
                return new ResultDto<OfficePlan>
                {
                    IsSuccess = false,
                    Message = "دفتری یا طرحی یا دفتری با این طرح وجود ندارد "
                };
            }

            return new ResultDto<OfficePlan>
            {
                Data = officePlan,
                IsSuccess = true,
            };
        }

        public async Task<ResultDto<List<OfficePlan>>> GetOfficePlans(string OfficeId)
        {
            var officePlans = await _context.OfficePlans.AsNoTracking().Where(p => p.OfficeId == OfficeId).ToListAsync();

            if (officePlans == null)
            {
                return new ResultDto<List<OfficePlan>>
                {
                    IsSuccess = false,
                };
            }

            return new ResultDto<List<OfficePlan>>
            {
                Data = officePlans,
                IsSuccess = true,
            };
        }

    }
}
