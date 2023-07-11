using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurastha.Api.Models.DTO.Request
{
    public class CreateEmployeeDTO: EmployeeAttribute
    {
        public string createdBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.MinValue;
    }
}
