using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TrashCollectorProject.Models
{
    public class Customer
    {
        // customer adress figure out where it should be
        // foreign key?

        [Key]
        public int Id { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is a Required Input")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is a Required Input")]
        public string LastName { get; set; }

        [Display(Name = "Adress")]
        [Required(ErrorMessage = "Adress is a Required Input")]
        public string Adress { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "City is a Required Input")]
        public string City { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "State is a Required Input")]
        public string State { get; set; }

        [Display(Name = "ZipCode")]
        [Required(ErrorMessage = "ZipCode is a Required Input")]
        public string ZipCode { get; set; }

        [Display(Name = "Weekly Pickup Day")]
        public DayOfWeek PickUpDay { get; set; }
        
        [Display(Name = "One Time Pickup")]
        public DateTime? OneTimePickup { get; set; }

        [Display(Name = "Suspend Pickup Start Date")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Suspend Pickup End Date ")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Owed Amount")]
        public int? OwedAmount { get; set; }

    }
}
