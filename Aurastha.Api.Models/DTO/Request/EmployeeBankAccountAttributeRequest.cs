using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurastha.Api.Models.DTO.Request
{
    public class EmployeeBankAccountAttributeRequest
    {
        public string BankName { get; set; } = string.Empty;

        public string AccountNumber { get; set; } = string.Empty;

        public string IFSCCode { get; set; } = string.Empty;
    }
}
