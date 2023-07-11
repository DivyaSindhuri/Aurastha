using Aurastha.Api.Models.Domain;
using Aurastha.Api.Models.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurastha.Api.Models.Profiles.EmployeeDetails
{
    public class EmployeeProfile: AutoMapper.Profile
    {
        public EmployeeProfile() 
        {
            CreateMap<EmployeeAttribute, Employee>()
                .ReverseMap();

            CreateMap<CreateEmployeeDTO, Employee>()
                .ReverseMap();

            CreateMap<EmployeeAddressAttributeRequest, EmployeeAddressDetails>()
                .ReverseMap();

            CreateMap<EmployeeBankAccountAttributeRequest, EmployeeBankAccount>()
                .ReverseMap();

            CreateMap<EmployeeReferenceAttributeRequest, EmployeeReference>()
                .ReverseMap();
        }
    }
}
