namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANH_MUC_SP
    {
        [Key]
        [StringLength(10)]
        public string MaDanhMuc { get; set; }

        [StringLength(250)]
        public string TenDanhMuc { get; set; }

        [StringLength(250)]
        public string MoTa { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgayDieuChinh { get; set; }
    }
}
