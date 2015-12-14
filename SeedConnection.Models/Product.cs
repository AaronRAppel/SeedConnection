namespace SeedConnection.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        public string Name { get; set; }

        [Required]
        [StringLength(128)]
        public string UserId { get; set; }

        public string Type { get; set; }

        public int? Quantity { get; set; }

        public DateTime? DataAvailable { get; set; }

        public bool? Selling { get; set; }
    }
}
