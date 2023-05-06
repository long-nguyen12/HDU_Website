namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FILE_QuanLyFile
    {
        public int ID { get; set; }

        public int? IDThuMuc { get; set; }

        [StringLength(500)]
        public string TenFile { get; set; }

        [StringLength(500)]
        public string LoaiFile { get; set; }

        public int? KichThuocFile { get; set; }

        [StringLength(500)]
        public string TenFileMoi { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? IDNguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }

        [StringLength(300)]
        public string PathExtract { get; set; }

        [StringLength(50)]
        public string FolderFunc { get; set; }

        public bool? DaSuDung { get; set; }
    }
}
