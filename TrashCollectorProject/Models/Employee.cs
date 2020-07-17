using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollectorProject.Models
{
    
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is a Required Input")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public int ZipCode { get; set; }


        [ForeignKey("User")]
        [Display(Name = "User Name")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }



    }
}
