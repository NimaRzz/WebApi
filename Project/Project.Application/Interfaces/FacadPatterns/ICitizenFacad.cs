using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Citizens;

namespace Project.Application.Interfaces.FacadPatterns
{
    public interface ICitizenFacad
    {
        IAddCitizenService AddCitizenService { get; }
       
        IUpdateCitizenService UpdateCitizenService { get; }

        IDeleteCitizenService DeleteCitizenService { get; }

        IGetCitizensService GetCitizensService { get; }
      
        IGetCitizenService GetCitizenService { get; }
    }
}
