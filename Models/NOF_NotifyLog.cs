namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NOF_NotifyLog
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string NotificationID { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        public string Contents { get; set; }

        [Column(TypeName = "ntext")]
        public string PostData { get; set; }

        public bool? Success { get; set; }

        [Column(TypeName = "ntext")]
        public string ResponseResult { get; set; }

        public int? IDNguoiGui { get; set; }

        [StringLength(100)]
        public string HoTenNguoiGui { get; set; }

        [StringLength(200)]
        public string DeviceInfoNguoiGui { get; set; }

        public DateTime? NgayTao { get; set; }

        public DateTime? NgayCapNhat { get; set; }
    }
}
