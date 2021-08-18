using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entities
{
    [Table("TREINA_USUARIOS")]
    public class Usuarios : BaseEntity<int>
    {
        [Key]
        [Required]
        [Column("USUARIO")]
        public string USUARIO { get; set; }


        [Required]
        [Column("SENHA")]
        public string SENHA { get; set; }

        [Required]
        [Column("NOME")]
        public string NOME { get; set; }

        [Column("VALIDADE_SENHA")]
        public DateTime VALIDADE_SENHA { get; set; }

    }
}