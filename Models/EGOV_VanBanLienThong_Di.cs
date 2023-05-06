namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGOV_VanBanLienThong_Di
    {
        public int ID { get; set; }

        public int? IDVanBanDi { get; set; }

        [StringLength(50)]
        public string SoKyHieu { get; set; }

        [StringLength(50)]
        public string CodeNumber { get; set; }

        [StringLength(50)]
        public string CodeNotation { get; set; }

        [StringLength(500)]
        public string TrichYeu { get; set; }

        [StringLength(500)]
        public string NoiDung { get; set; }

        [StringLength(100)]
        public string DocId { get; set; }

        [StringLength(200)]
        public string DocumentId { get; set; }

        [StringLength(50)]
        public string Place { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PromulgationDate { get; set; }

        public int? Type { get; set; }

        public int? IDLoaiVanBan { get; set; }

        [StringLength(100)]
        public string TypeName { get; set; }

        [StringLength(100)]
        public string SignerCompetence { get; set; }

        [StringLength(100)]
        public string SignerPosition { get; set; }

        [StringLength(50)]
        public string SignerFullName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DueDate { get; set; }

        public int? Priority { get; set; }

        [StringLength(100)]
        public string SphereOfPromulgation { get; set; }

        [StringLength(10)]
        public string TyperNotation { get; set; }

        public int? PromulgationAmount { get; set; }

        public int? PageAmount { get; set; }

        [StringLength(50)]
        public string FromOrganId { get; set; }

        [StringLength(200)]
        public string FromOrganizationInCharge { get; set; }

        [StringLength(200)]
        public string FromOrganName { get; set; }

        [StringLength(250)]
        public string FromOrganAdd { get; set; }

        [StringLength(100)]
        public string FromEmail { get; set; }

        [StringLength(50)]
        public string FromTelephone { get; set; }

        [StringLength(50)]
        public string FromFax { get; set; }

        [StringLength(100)]
        public string FromWebsite { get; set; }

        [StringLength(300)]
        public string StaffInfoDepartment { get; set; }

        [StringLength(300)]
        public string StaffInfoStaff { get; set; }

        [StringLength(50)]
        public string StaffInfoMobile { get; set; }

        [StringLength(100)]
        public string StaffInfoEmail { get; set; }

        public bool? IsDaChuyen { get; set; }

        public int? IDNguoiChuyen { get; set; }

        public DateTime? NgayChuyen { get; set; }

        public int? BussinessDocType { get; set; }
    }
}
