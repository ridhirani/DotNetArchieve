using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Login_Register.Models
{
    public class UserAccount
    {


        [Key]
        [Display(Name ="User ID")]
        public int UserID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage ="First Name is Required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage ="Last Name is Required")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage ="Email is Required")]
        public string Email { get; set; }

        //[Display(Name = "Phone")]
        //[Required(ErrorMessage = "Email is Required")]
        //public char Contact { get; set; }


        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is Required")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Enter Your Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password ")]
        [Compare("Password",ErrorMessage ="Both Password Should be same")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
 
}