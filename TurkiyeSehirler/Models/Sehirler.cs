namespace TurkiyeSehirler
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sehirler")]
    public partial class Sehirler
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int BolgeId { get; set; }

        [Required]
        [StringLength(50)]
        public string SehirAd { get; set; }

        public int Nufus { get; set; }

        public virtual Bolgeler Bolgeler { get; set; }
    }
}
