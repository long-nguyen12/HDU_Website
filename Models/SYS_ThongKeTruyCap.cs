namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_ThongKeTruyCap
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoLuotTruyCap { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime NgayTruyCap { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime LanTruyCapGanNhat { get; set; }

        public int? ForWeb { get; set; }
    }
}
