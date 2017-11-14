namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tag")]
    public partial class Tag
    {
        [Key]
        [StringLength(10)]
        public string MaTag { get; set; }

        [StringLength(50)]
        public string TenTag { get; set; }
    }
}
