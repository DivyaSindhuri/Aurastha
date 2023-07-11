using Aurastha.Api.Business.Interfaces;
using Aurastha.Api.Models.Domain;
using Aurastha.Api.Models.DTO.Request;
using Aurastha.Api.Models.DTO.Response;
using Aurastha.Api.Repository.DatabaseContext;
using Aurastha.Api.Repository.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Aurastha.Api.Business
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository
            , IMapper mapper) 
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse> AddEmployee(CreateEmployeeDTO employee)
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                var employeeDetails = new Employee();

                //employeeDetails = ConvertObject(employee);
                employeeDetails = _mapper.Map<Employee>(employee);                

                employees = await _employeeRepository.AddEmployee(employeeDetails);
            }
            catch(Exception ex)
            {
                var message = ex.Message;
            }

            return new BaseResponse(employees, System.Net.HttpStatusCode.OK);
        }

        private Employee ConvertObject(CreateEmployeeDTO employeeDetails)
        {
            var employee = new Employee
            {
                AdhaarNumber = employeeDetails.AdhaarNumber,
                AmountToNomineeInRs = employeeDetails.AmountToNomineeInRs,
                PANNumber = employeeDetails.PANNumber,
                PersonalEmailID = employeeDetails.PersonalEmailID,
                PrimaryContactNumber = employeeDetails.PrimaryContactNumber,
                CreatedBy = employeeDetails.createdBy,
                CreatedDate = DateTime.UtcNow,
                OfficialContactNumber = employeeDetails.OfficialContactNumber,
                OfficialEmailID = employeeDetails.OfficialEmailID,
                Designation = employeeDetails.Designation,
                EmployeeName = employeeDetails.EmployeeName,
                Employee_Id = employeeDetails.Employee_Id,
                WorkEndTime = employeeDetails.WorkEndTime,
                WorkStartTime = employeeDetails.WorkStartTime,
                isDeleted = employeeDetails.isDeleted,
                JoiningDate = employeeDetails.JoiningDate,
                NomineeName = employeeDetails.NomineeName,
                NomineeRelation = employeeDetails.NomineeRelation,
                NomineeSignature = employeeDetails.NomineeSignature,
                Responsibilities = employeeDetails.Responsibilities,
                SecondaryContactNumber = employeeDetails.SecondaryContactNumber
            };
            employee.BankAccountDetails = new List<EmployeeBankAccount>() 
            { 
                new EmployeeBankAccount
                {
                    AccountNumber = employeeDetails.BankAccountDetails[0].AccountNumber,
                    BankName = employeeDetails.BankAccountDetails[0].BankName,
                    IFSCCode = employeeDetails.BankAccountDetails[0].IFSCCode
                }
            };
            foreach(var address in employeeDetails.Addresses)
            {
                employee.Addresses.Add(new EmployeeAddressDetails
                {
                    Address = address.Address,
                    City = address.City,
                    PostalCode = address.PostalCode,
                    AddressType = address.AddressType
                });
            }
            foreach(var refs in employeeDetails.ReferenceList)
            {
                employee.ReferenceList.Add(new EmployeeReference
                {
                    Name = refs.Name,
                    ContactNumber = refs.ContactNumber,
                    Relationship = refs.Relationship,
                    ReferenceTypes = refs.ReferenceTypes
                });
            }

            return employee;
        }
    }
}
