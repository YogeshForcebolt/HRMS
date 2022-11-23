using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Models
{
    public class EmployeeDetails
    {
        public string EmpId { get; set; }
       
        public String Emptype { get; set; }
        public string EmpFullName { get; set; }

        public DateTime EmpDateofBirth { get; set; }

        public string EmpGender { get; set; }

        public string EmpFathersName { get; set; }

        public string EmpMothersName { get; set; }

        public long EmpMobilenumber { get; set; }
      
        public string  EmpEmail { get; set; }

        public string EmpMartialStatus { get; set; }
        
        public string EmpPassword { get; set; }

        public string  EmpBloodGroup { get; set; }

        public string EmpPhysicallyChallenged { get; set; }

        public long EmpAadharCardNumaber { get; set; }

        public string  EmpPanCardNumber { get; set; }

        public string EmpStreetAddress { get; set; }

        public string EmpCity { get; set; }

        public string  EmpState { get; set; }

        public String EmpCountry { get; set; }

        public int EmpPinCode { get; set; }



    }
}
