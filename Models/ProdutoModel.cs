using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteTecnicoV.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        [Required]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("Preco")]
        public int Preco { get; set; }

        //[ForeignKey("Categoria")]
        [Column("CategoriaId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
