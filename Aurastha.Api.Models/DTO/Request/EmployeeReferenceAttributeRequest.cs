﻿using Aurastha.Api.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurastha.Api.Models.DTO.Request
{
    public class EmployeeReferenceAttributeRequest
    {
        public EmployeeReferenceTypes ReferenceTypes { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Relationship { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
    }
}
