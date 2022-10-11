using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Login_Register.Models
{
    public class Freshers_Training2022Entities : DbContext
    {
        public DbSet<UserAccount> userAccounts { get; set; }
    }
}