using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Working_Of_Innominds_People_Crud_Operation.Models
{
    /// <summary>
    /// Represents a SecuritySystemMaintanace class
    /// </summary>
    public class SecuritySystemMaintanace
    {
        #region SecuritySystemMaintanace Properties
        [Key]
        public int MaintanceId { get; set; }
        public int Lights { get; set; }
        public int Cameras { get; set; }
        public int Sensors { get; set; }
        public string Rooms { get; set; }
        public string Chairs { get; set; }

        #endregion
    }
}
