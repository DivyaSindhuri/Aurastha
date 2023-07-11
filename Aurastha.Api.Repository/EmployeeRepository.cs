using Aurastha.Api.Models.Domain;
using Aurastha.Api.Models.DTO.Request;
using Aurastha.Api.Repository.DatabaseContext;
using Aurastha.Api.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurastha.Api.Repository
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly DataContext _context;
        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Employee>> AddEmployee(Employee employee)
        {
            try
            {
                _context.Employees.Add(employee);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                var message = ex.ToString();
            }

            return await _context.Employees.ToListAsync();
        }
    }
}
