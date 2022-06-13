using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Working_Of_Innominds_People_Crud_Operation.Models
{
    /// <summary>
    /// Represents a Courier_To_The_Company class
    /// </summary>
    public class Courier_To_The_Company
    {
        #region Courier_To_The_Company Properties

        [Key]
        public int CourierId { get; set; }
 
        [DataType(DataType.Date)]
        public DateTime CourierDate { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(30, ErrorMessage = "Name can't be longer than 30 characters")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "EmpLocation  is required")]
        [StringLength(20, ErrorMessage = "EmpLocation can't be longer than 20 characters")]
        public string EmpLocation { get; set; }


        [Required(ErrorMessage = "PhoneNumber is required")]
        [DataType(DataType.PhoneNumber)]
        public long PhoneNumber { get; set; }

        [Required(ErrorMessage = "EmailID  is required")]
        [StringLength(20, ErrorMessage = "EmailID can't be longer than 20 characters")]
        public string EmailID { get; set; }

        [ForeignKey(nameof(Employee))]
        public int EmpId { get; set; }
        // public Employee EmpId { get; set; }

        #endregion
    }
}
