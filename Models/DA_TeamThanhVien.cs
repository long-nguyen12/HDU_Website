namespace HDU_Website.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DA_TeamThanhVien
    {
        public int ID { get; set; }

        public int IDTeam { get; set; }

        public int IDThanhVien { get; set; }
    }
}
