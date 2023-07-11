using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurastha.Api.Models.Domain
{
    public class Employee
    {
        public int Id { get; set; } 
        public string Employee_Id { get; set; } = string.Empty;
        public string EmployeeName { get; set; } = string.Empty;
        public string PANNumber { get; set; } = string.Empty;
        public string AdhaarNumber { get; set; } = string.Empty;     
        public string PrimaryContactNumber { get; set; } = string.Empty;
        public string SecondaryContactNumber { get; set; } = string.Empty;
        public string OfficialContactNumber { get; set; } = string.Empty;
        public string PersonalEmailID { get; set; } = string.Empty;
        public string OfficialEmailID { get; set; } = string.Empty;
        public List<EmployeeAddressDetails> Addresses { get; set; }
        public string NomineeName { get; set; } = string.Empty;
        public string NomineeRelation { get; set; } = string.Empty;
        public string NomineeSignature { get; set; } = string.Empty;
        public string AmountToNomineeInRs { get; set;} = string.Empty;
        public List<EmployeeReference> ReferenceList { get; set; }
        public List<EmployeeBankAccount> BankAccountDetails { get; set; }
        public string Designation { get; set; } = string.Empty;
        public string Responsibilities { get; set; } = string.Empty;
        public string WorkStartTime { get; set; } = string.Empty;
        public string WorkEndTime { get; set; } = string.Empty;
        public string JoiningDate { get; set; } = string.Empty;
        public string CreatedBy { get; set;} = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.MinValue;
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime ModifiedDate { get; set; } = DateTime.MinValue;
        public Boolean isDeleted { get; set;} = false;
        public Employee()
        {
            ReferenceList = new List<EmployeeReference>();
            Addresses = new List<EmployeeAddressDetails>();
            BankAccountDetails = new List<EmployeeBankAccount>();
        }
    }
}
