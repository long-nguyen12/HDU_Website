namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_LichCongTacDiemDanh
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDLichCongTac { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDNguoiDung { get; set; }

        public int? IDNguoiDiemDanh { get; set; }

        public DateTime? NgayDiemDanh { get; set; }

        public bool? IsCoMat { get; set; }
    }
}
