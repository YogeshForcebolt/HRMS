using HRMS.Models;
using hrms_portal.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nancy.Json;
using Newtonsoft.Json;

namespace HRMS.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IConfiguration configuration;

        public EmployeeController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IActionResult AddEmployee()
        {
            var eid = new Repository(configuration);
            string id = eid.GetEmployeeId();
           
            return View("AddEmployee",id);
        }

        [HttpPost]
        public IActionResult AddEmployee(EmployeeDetails employeeDetail,  EmployeeProfessionalDeatils employeeProfessionalDeatil, EmployeeEmergencyDetails employeeEmergencyDetail )
        {

            var eid = new Repository(configuration);
        //    eid.GetEmployeeId();
          //  var json = JsinC.Serialize(employeeFormModel);
            if (ModelState.IsValid)
            {
                var formData = new EmployeeFormModel
                {
                    EmployeeDetail = employeeDetail,
                    EmployeeEmergencyDetail = employeeEmergencyDetail,
                    EmployeeProfessionalDeatil = employeeProfessionalDeatil
                };

                var jsonData = JsonConvert.SerializeObject(formData);
               bool insert = eid.AddEmployee(jsonData);
                if (insert == true)
                    return View("Thanks",employeeDetail);
                else
                    return View("RegistrationError");
            }
            else
                return View("RegistrationError");
        }


        public IActionResult UpdateEmployee()
        {
            return View();
        }

    }
}
