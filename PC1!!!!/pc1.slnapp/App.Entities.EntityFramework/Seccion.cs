namespace App.Entities.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Seccion")]
    public partial class Seccion
    {
        public int SeccionID { get; set; }

        [Required]
        [StringLength(10)]
        public string Nombre { get; set; }

        public int GradoID { get; set; }

        public virtual Grado Grado { get; set; }
    }
}
