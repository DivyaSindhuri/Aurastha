using Aurastha.Api.Models.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Aurastha.Api.Models.Domain
{
    public class EmployeeReference
    {
        public int Id { get; set; }
        public EmployeeReferenceTypes ReferenceTypes { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Relationship { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        [JsonIgnore]
        public Employee Employee { get; set; }
    }
}
