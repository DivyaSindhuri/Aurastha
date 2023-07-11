using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Aurastha.Api.Models.Domain
{
    public class EmployeeBankAccount
    {
        public int Id { get; set; }

        public string BankName { get; set; } = string.Empty;

        public string AccountNumber { get; set; } = string.Empty;

        public string IFSCCode { get; set; } = string.Empty;

        [JsonIgnore]
        public Employee Employee { get; set; }

    }
}
