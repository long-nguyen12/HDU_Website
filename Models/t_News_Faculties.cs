namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_News_Faculties
    {
        [Key]
        public int newsID { get; set; }

        public int? iddonvi { get; set; }

        public int? catenewsID { get; set; }

        [StringLength(200)]
        public string title { get; set; }

        [StringLength(1000)]
        public string summary { get; set; }

        [Column(TypeName = "ntext")]
        public string content { get; set; }

        [StringLength(500)]
        public string imgUrl { get; set; }

        public DateTime? createDate { get; set; }

        public DateTime? editdate { get; set; }

        public DateTime? publishdate { get; set; }

        [StringLength(100)]
        public string userCreate { get; set; }

        [StringLength(100)]
        public string userEdit { get; set; }

        [StringLength(100)]
        public string userPublish { get; set; }

        public bool? isPublish { get; set; }

        [StringLength(50)]
        public string lang { get; set; }

        public int? timeview { get; set; }
    }
}
