using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Working_Of_Innominds_People_Crud_Operation.Models
{
    /// <summary>
    /// Represents a Cafetaria class
    /// </summary>
    public class Cafetaria
    {
        #region Cafetaria Properties

        [Key]
        public int Sno { get; set; }

        [Required(ErrorMessage = "Tea  is required")]
        public int Tea { get; set; }

        [Required(ErrorMessage = "Cofee  is required")]
        public int Cofee { get; set; }

        [Required(ErrorMessage = "GreenTea  is required")]
        public int GreenTea { get; set; }

        
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        //[ForeignKey(nameof(Employee))]
        //public int EmpId { get; set; }
        // public Employee EmpId { get; set; } this is for displaying the all the data releted to the employee so we don't want that

        #endregion
    }
    /// <summary>
    /// Represents a CafeteriaOperation class for To get the Average,Addition etc...
    /// </summary>
    public class CafeteriaOperation
    {
        #region CafeteriaOperation properties

        [Key]
        public int Sno { get; set; }

        [Required(ErrorMessage = "Tea  is required")]
        public int Tea { get; set; }

        [Required(ErrorMessage = "Cofee  is required")]
        public int Cofee { get; set; }

        [Required(ErrorMessage = "GreenTea  is required")]
        public int GreenTea { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public int Avarage { get; set; }

        #endregion
    }
}
