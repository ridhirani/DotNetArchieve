using System;
using System.Collections.Generic;

namespace CRUD_WEB_API.Models
{
    public partial class Aemployee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
    }
}
