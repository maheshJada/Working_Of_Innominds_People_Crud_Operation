using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Working_Of_Innominds_People_Crud_Operation.Models
{
    /// <summary>
    /// Represents a Visitors class
    /// </summary>
    public class Visitors
    {
        #region VisitorsProperties
       
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter EmpId if he is in Organization Otherwise put NONE")]
        public string EmpId { get; set; }

        [Required(ErrorMessage = "Name  is required")]
        [StringLength(20, ErrorMessage = "Name can't be longer than 20 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "PhoneNumber  is required")]
        [DataType(DataType.PhoneNumber)]
        public long PhoneNumber { get; set; }

        [Required(ErrorMessage = "EmailId  is required")]
        [StringLength(20, ErrorMessage = "EmailId can't be longer than 20 characters")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Location  is required")]
        [StringLength(20, ErrorMessage = "Location can't be longer than 20 characters")]
        public string Location { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        #endregion
    }
}
