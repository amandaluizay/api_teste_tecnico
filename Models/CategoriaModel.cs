using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteTecnicoV.Models
{
    [Table("Categoria")]
    public class Categoria 
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }
        [Column("Descricao")]
        public string Descricao { get; set; }

        //public ICollection<Produto> Produtos { get; set; }


    }


}
