using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppointmentScheduling.Utility
{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string Patient = "Patient";
        public static string Doctor = "Doctor";

        public static List<SelectListItem> GetRolesForDropDown()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem {Text = Helper.Admin, Value = Helper.Admin},
                new SelectListItem {Text = Helper.Patient, Value = Helper.Patient},
                new SelectListItem {Text = Helper.Doctor, Value = Helper.Doctor},
            };
        }
    }
}
