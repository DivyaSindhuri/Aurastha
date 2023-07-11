using Aurastha.Api.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurastha.Api.Models.DTO.Request
{
    public class EmployeeAttribute
    {
        public string Employee_Id { get; set; } = string.Empty;
        public string EmployeeName { get; set; } = string.Empty;
        public string PANNumber { get; set; } = string.Empty;
        public string AdhaarNumber { get; set; } = string.Empty;
        public string PrimaryContactNumber { get; set; } = string.Empty;
        public string SecondaryContactNumber { get; set; } = string.Empty;
        public string OfficialContactNumber { get; set; } = string.Empty;
        public string PersonalEmailID { get; set; } = string.Empty;
        public string OfficialEmailID { get; set; } = string.Empty;
        public List<EmployeeAddressAttributeRequest> Addresses { get; set; }
        public string NomineeName { get; set; } = string.Empty;
        public string NomineeRelation { get; set; } = string.Empty;
        public string NomineeSignature { get; set; } = string.Empty;
        public string AmountToNomineeInRs { get; set; } = string.Empty;
        public List<EmployeeReferenceAttributeRequest> ReferenceList { get; set; }
        public List<EmployeeBankAccountAttributeRequest> BankAccountDetails { get; set; }
        public string Designation { get; set; } = string.Empty;
        public string Responsibilities { get; set; } = string.Empty;
        public string WorkStartTime { get; set; } = string.Empty;
        public string WorkEndTime { get; set; } = string.Empty;
        public string JoiningDate { get; set; } = string.Empty;
        public Boolean isDeleted { get; set; } = false;
    }
}
