using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domain.Repository.Role;
using Project.Infra.Data.Contexts;

namespace Project.Infra.Data.Repositories.Role
{
    public class RoleRepository:IRoleRepository
    {
        private readonly DataBaseContext _context;
        public RoleRepository(DataBaseContext context) 
        {
      
            _context = context;
       
        }

        public async Task<bool> IsExists(string Name)
        {
          
            return true;
        }
    }
}
