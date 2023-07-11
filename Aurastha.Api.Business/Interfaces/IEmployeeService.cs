using Aurastha.Api.Models.Domain;
using Aurastha.Api.Models.DTO.Request;
using Aurastha.Api.Models.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurastha.Api.Business.Interfaces
{
    public interface IEmployeeService
    {
        Task<BaseResponse> AddEmployee(CreateEmployeeDTO employee);
    }
}
