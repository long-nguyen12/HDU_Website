namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_FileAttach
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string TenFile { get; set; }

        [StringLength(100)]
        public string LoaiFile { get; set; }

        public int? KichThuocFile { get; set; }

        [StringLength(500)]
        public string TenFileMoi { get; set; }

        [StringLength(50)]
        public string CheckSum { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        [StringLength(50)]
        public string FolderFunc { get; set; }

        public bool? DaSuDung { get; set; }

        [StringLength(500)]
        public string DigitalSignatureFile { get; set; }

        [StringLength(500)]
        public string TenFileKySo { get; set; }
    }
}
