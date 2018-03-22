using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bshapi.Models
{
    public class Employee
    {
         public string emp_id { get; set; }
         [Required(ErrorMessage = "Enter Name")]
         public string emp_name { get; set; }
         [Required(ErrorMessage = "Enter Address")] 
         public string emp_address { get; set; }
         [Required(ErrorMessage = "Enter Mobile")]
         public string emp_mobile { get; set; }
         public string emp_email { get; set; }
         [DataType(DataType.Date)]

         [Required(ErrorMessage = "Enter JoinDate")]
         public DateTime emp_joindate { get; set; }
         [DataType(DataType.Date)]

         [Required(ErrorMessage = "Enter ValideDate")]
         public DateTime emp_validedate { get; set; }
       
    
    }
}