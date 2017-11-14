namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [StringLength(10)]
        public string UserID { get; set; }

        [StringLength(30)]
        public string UserName { get; set; }

        [StringLength(10)]
        public string Pass { get; set; }

        [StringLength(30)]
        public string FullName { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        

        public DateTime? CreateDate { get; set; }

        
        public bool Status { get; set; }
    }
}
