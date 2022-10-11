using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assignment_3.Models
{
    public class FriendsClass
    {
        [Display(Name = "Friend ID")]

        [Required(ErrorMessage = "Friend Id is Required")]

        public int FriendID { get; set; }

        [Display(Name = " Friend Name")]

        public string FriendName { get; set; }

        [Required(ErrorMessage = "Friend Name Empty not allowed")]

        [Display(Name = "Place")]



        public string Place { get; set; }

        public static FriendsClass GetFriends()
        {
            FriendsClass frnd = new FriendsClass();
            return frnd;

        }

    }
        //

        //
        ////[Display(Name = " Friend Name")]
        
        ////[Required(ErrorMessage = "Friend Name Empty not allowed")]

    


}