namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TS_LichSuImportDetail
    {
        public int ID { get; set; }

        public int? IDLichSuImport { get; set; }

        [StringLength(200)]
        public string MaHoSo { get; set; }

        [StringLength(200)]
        public string HoDem { get; set; }

        [StringLength(200)]
        public string Ten { get; set; }

        public string LyDo { get; set; }
    }
}
