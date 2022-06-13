using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Working_Of_Innominds_People_Crud_Operation.Models
{
    /// <summary>
    /// Represents a Employee class
    /// </summary>
    public class Employee
    {
        #region Employee Properties

        [Key]
        public int EmpId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(30, ErrorMessage = "Name can't be longer than 30 characters")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required")]
        [DataType(DataType.PhoneNumber)]
        public long PhoneNumber { get; set; }

        [Required(ErrorMessage = "EmailID  is required")]
        [StringLength(40, ErrorMessage = "EmailID can't be longer than 40 characters")]
        public string EmailID { get; set; }

        [Required(ErrorMessage ="EmpLocation  is required")]
        [StringLength(40, ErrorMessage = "EmpLocation can't be longer than 40 characters")]
        public string EmpLocation { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "EmpCategory  is required")]
        [StringLength(40, ErrorMessage = "EmpCategory can't be longer than 40 characters")]
        public string EmpCategory { get; set; }

        //Checking changes

        #endregion
    }
}
