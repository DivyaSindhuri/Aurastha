using Aurastha.Api.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Aurastha.Api.Models.Domain
{
    public class EmployeeAddressDetails
    {
        public int Id { get; set; }
        public AddressTypes AddressType { get; set; }
        public string Address { get; set; } = string.Empty;
        public string City { get; set; }    = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        [JsonIgnore]
        public Employee Employee { get; set; }
    }
}
