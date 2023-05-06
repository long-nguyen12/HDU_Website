namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_LichCongTacDetail
    {
        public int ID { get; set; }

        public int? IDNguoiThamDu { get; set; }

        public int? IDLichCongTac { get; set; }

        public DateTime? NgayXem { get; set; }

        public int? LoaiDoiTuong { get; set; }
    }
}
