using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_filmes_senai.Domains
{
    [Table("Filme")]   
    public class Filme
    {
        [Key]
        public Guid IdFilme { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Nome do Filme é Obrigatório!")]
        public string? Titulo { get; set; }

        /// <summary>
        /// Referencia tabeloGenero
        /// </summary>
        
        public Guid IdGenero { get; set; }

        [ForeignKey("IdGenero")]
        public Genero? Genero { get; set; }
    }
}