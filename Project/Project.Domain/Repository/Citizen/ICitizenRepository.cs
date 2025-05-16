using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Common.Dto;
using Project.Domain.Repository.BaseRepository;
using CitizenModel = Project.Domain.Entities.Citizens.Citizen;

namespace Project.Domain.Repository.Citizen
{
    public interface ICitizenRepository:IBaseRepository
    {
        Task<ResultDto> GetCitizen(CitizenModel requestCode);
    
    }
}
