using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace K19_CopaDoMundo.Models
{
    [Table("Jogadores")]
    public class Jogador
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo posição é obrigatório.")]
        public string Posicao { get; set; }

        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "O campo altura é obrigatório.")]
        public double Altura { get; set; }

        public int SelecaoId { get; set; }

        [InverseProperty("Jogadores")]
        public virtual Selecao Selecao { get; set; }
    }
}