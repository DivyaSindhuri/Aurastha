using Aurastha.Api.Models.Domain;
using Aurastha.Api.Models.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurastha.Api.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> AddEmployee(Employee employee);
    }
}
