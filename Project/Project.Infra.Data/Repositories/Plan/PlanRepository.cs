using Project.Domain.Common.Dto;
using Project.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Repository.Plan;

namespace Project.Infra.Data.Repositories.Plan
{
    public class PlanRepository:BaseRepository.BaseRepository, IPlanRepository
    {
        private readonly DataBaseContext _context;

        public PlanRepository(DataBaseContext context) : base(context)
        {
            _context = context;
        }

    }
}
