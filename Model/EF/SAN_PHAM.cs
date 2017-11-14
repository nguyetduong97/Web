namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAN_PHAM
    {
        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(100)]
        public string TenSP { get; set; }

        [StringLength(250)]
        public string MoTa { get; set; }

        [StringLength(250)]
        public string HinhAnh { get; set; }

        [Column(TypeName = "xml")]
        public string HinhAnhKhac { get; set; }

        public decimal? Gia { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(10)]
        public string DanhMuc { get; set; }

        [Column(TypeName = "ntext")]
        public string NoiDung { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgayDieuChinh { get; set; }

        public DateTime? Top { get; set; }

        public int? LuotXem { get; set; }
    }
}
