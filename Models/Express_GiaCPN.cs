namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Express_GiaCPN
    {
        public int ID { get; set; }

        public int? IDBangGia { get; set; }

        public int? TuTrongLuong { get; set; }

        public int? DenTrongLuong { get; set; }

        public decimal? NoiTinh { get; set; }

        public decimal? Den300km { get; set; }

        public decimal? Tren300km { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public int? IDQuocGia { get; set; }

        public int? ForWeb { get; set; }

        public int? IDNguoiTao { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? IDNguoiCapNhat { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public bool? IsDelete { get; set; }

        public int? NguoiDelete { get; set; }

        public DateTime? NgayDelete { get; set; }
    }
}
