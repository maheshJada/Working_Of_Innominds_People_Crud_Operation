using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Working_Of_Innominds_People_Crud_Operation.Models
{
    /// <summary>
    /// Represents a Employee class
    /// </summary>
    [Table("Team")]
    public class Team
    {
        #region Team Properties

        [ForeignKey(nameof(Employee))]
        public int EmpId { get; set; }

        public string SenderName { get; set; }

        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; }
     

        #endregion
    }
}
