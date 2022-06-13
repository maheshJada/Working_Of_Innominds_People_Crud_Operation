using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Working_Of_Innominds_People_Crud_Operation.Models
{

    /// <summary>
    /// Represents a It class
    /// </summary>
    public class It
    {
        #region It properties

        public int Id { get; set; }

        [Required(ErrorMessage = "AssertId  is required")]
        public string AssertId { get; set; }

        [Required(ErrorMessage = "AssertName  is required")]
        [StringLength(20, ErrorMessage = "AssertName can't be longer than 20 characters")]
        public string AssertName { get; set; }

        [DataType(DataType.Date)]
        public DateTime AssertDate { get; set; }

        [Required(ErrorMessage = "EmpName  is required")]
        [StringLength(20, ErrorMessage = "EmpName can't be longer than 20 characters")]
        public string EmpName { get; set; }

        [ForeignKey(nameof(Employee))]
        public int EmpId { get; set; }

        [Required(ErrorMessage = "EmailId  is required")]
        [StringLength(20, ErrorMessage = "EmailId can't be longer than 20 characters")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required")]
        [DataType(DataType.PhoneNumber)]
        public long PhoneNumber { get; set; }

        #endregion
    }
}
