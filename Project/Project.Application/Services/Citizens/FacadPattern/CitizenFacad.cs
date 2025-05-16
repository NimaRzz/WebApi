using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Interfaces.Citizens;
using Project.Application.Interfaces.FacadPatterns;
using Project.Application.Services.Citizens.Commands.AddCitizen;
using Project.Application.Services.Citizens.Commands.DeleteCitizen;
using Project.Application.Services.Citizens.Commands.UpdateCitizen;
using Project.Application.Services.Citizens.Queries.GetCitizen;
using Project.Application.Services.Citizens.Queries.GetCitizens;
using Project.Domain.Repository.Citizen;

namespace Project.Application.Services.Citizens.FacadPattern
{
    public class CitizenFacad : ICitizenFacad
    {

        private readonly ICitizenRepository _repository;

        public CitizenFacad(ICitizenRepository repository)
        {
            _repository = repository;
        }

        private IAddCitizenService _addCitizenService;

        public IAddCitizenService AddCitizenService
        {
            get
            {
                return _addCitizenService = _addCitizenService ?? new AddCitizenService(_repository);
            }

        }

        private IUpdateCitizenService _updateCitizenService;

        public IUpdateCitizenService UpdateCitizenService
        {
            get
            {

                return _updateCitizenService = _updateCitizenService ?? new UpdateCitizenService(_repository);
            }
        }

        private IDeleteCitizenService _deleteCitizenService;

        public IDeleteCitizenService DeleteCitizenService
        {
            get
            {

                return _deleteCitizenService = _deleteCitizenService ?? new DeleteCitizenService(_repository);
            }
        }
        private IGetCitizensService _getCitizensService;

        public IGetCitizensService GetCitizensService
        {
            get
            {

                return _getCitizensService = _getCitizensService ?? new GetCitizensService(_repository);
            }
        } 
        private IGetCitizenService _getCitizenService;

        public IGetCitizenService GetCitizenService
        {
            get
            {

                return _getCitizenService = _getCitizenService ?? new GetCitizenService(_repository);
            }
        }
    }
}