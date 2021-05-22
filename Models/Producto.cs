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

        [Required(ErrorMessage = "Por favor ingrese nombre de producto")]
        [Display(Name="Nombre Producto")]
        public String Name {get; set;}

        [Required(ErrorMessage = "Please enter Price")]
        public Decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter Image Name")]
        public String ImagenName { get; set; }

        [Required(ErrorMessage = "Please enter Due Date")]
        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Please enter Status")]
        public String Status { get; set; }

    }
}