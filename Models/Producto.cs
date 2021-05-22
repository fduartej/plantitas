using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace plantitas.Models
{
    [Table("t_product")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID {get; set;}

        public String Name {get; set;}

        public Decimal Price { get; set; }

        public String ImagenName { get; set; }

        public DateTime DueDate { get; set; }

        public String Status { get; set; }

    }
}