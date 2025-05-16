using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Repository.Role
{
    public interface IRoleRepository
    {
        Task<bool> IsExists(string Name);
    }
}
