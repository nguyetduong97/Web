namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Menu_Type
    {
        [Key]
        [StringLength(10)]
        public string MaMenu { get; set; }

        [StringLength(50)]
        public string TenMenu { get; set; }
    }
}
