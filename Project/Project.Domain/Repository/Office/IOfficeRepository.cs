using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Common.Dto;
using Project.Domain.Entities.Province;
using Project.Domain.Repository.BaseRepository;
using Project.Domain.Entities.Offices;

namespace Project.Domain.Repository.Office
{
    public interface IOfficeRepository:IBaseRepository
    {
        Task<List<WorkCalendar>> GetAllWorkCalendarsAsync(string OfficeId);

        Task<ResultDto<OfficePlan>> GetOfficePlan(string OfficeId, string PlanId);

        Task<ResultDto<List<OfficePlan>>> GetOfficePlans(string OfficeId);
    }
}
