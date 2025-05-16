using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Services.Citizens.Commands.DTOs;

namespace Project.Application.Services.Citizens.Commands.UpdateCitizen
{
    public class RequestUpdateCitizenDto : CitizenCommandsDto
    {
        public long Id { get; set; }
    }
}
