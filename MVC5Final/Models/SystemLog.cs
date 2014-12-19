namespace MVC5Final.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SystemLog
    {
        [Key]
        public int LogId { get; set; }

        public string UserName { get; set; }
        public string ControllerName { get; set; }
        
        public string ActionName { get; set; }

        public string Method { get; set; }
        
        public string IPAddress { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
