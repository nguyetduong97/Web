namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tin_Tuc
    {
        [Key]
        [StringLength(10)]
        public string MaTin { get; set; }

        [StringLength(100)]
        public string TenTin { get; set; }

        [StringLength(250)]
        public string MoTa { get; set; }

        [StringLength(250)]
        public string HinhAnh { get; set; }

        [Column(TypeName = "xml")]
        public string HinhAnhKhac { get; set; }

        [Column(TypeName = "ntext")]
        public string NoiDung { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? LuotXem { get; set; }

        [StringLength(10)]
        public string Tag { get; set; }
    }
}
