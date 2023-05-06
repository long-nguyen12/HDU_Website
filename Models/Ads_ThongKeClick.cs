namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ads_ThongKeClick
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDQuangCao { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime NgayClick { get; set; }

        public int? Click { get; set; }
    }
}
