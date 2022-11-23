using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Models
{
    public class EmployeeProfessionalDeatils
    {
        public string EmpId { get; set; }
        public string EmpDepartment { get; set; }

        public string EmpDesignation { get; set; }

        public string EmpReportingTo { get; set; }

        public string EmpExperience { get; set; }

        public DateTime EmpJobStartDate { get; set; }

        public DateTime EmpJobEndingDate { get; set; }



    }
}
