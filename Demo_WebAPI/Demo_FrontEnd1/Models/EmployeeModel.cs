using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo_FrontEnd1.Models
{
    public class EmployeeModel
    {
        [Display(Name="EmployeeID")]
        public int EMPId { get; set; }

        [Display(Name = "FirstName")]

        public string FirstName { get; set; }

        [Display(Name = "LastName")]

        public string LastName { get; set; }
    }
}