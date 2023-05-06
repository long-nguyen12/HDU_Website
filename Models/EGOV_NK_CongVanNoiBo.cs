namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_NK_CongVanNoiBo
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string TableName { get; set; }

        public string PrimaryKey { get; set; }

        public string GiaTriCu { get; set; }

        public string GiaTriMoi { get; set; }

        public string GiaTriThayDoi { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string Loai { get; set; }

        public string Hash { get; set; }
    }
}
