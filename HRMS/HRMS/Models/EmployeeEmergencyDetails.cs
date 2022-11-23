using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Models
{
    public class EmployeeEmergencyDetails
    {
        public string   EmpId { get; set; }
        public string EmpGuadianName { get; set; }

        public string EmpGuardianEmail { get; set; }

        public long EmpGuardianMobileNumber { get; set; }

        public string EmpGuardianRelationshipType { get; set; }

    }
}
