using System;
using System.ComponentModel.DataAnnotations;

namespace filmesapi.Data.Dtos
{
    public class ReadFilmeDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo \"Título\" é obrigatório.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo \"Diretor\" é obrigatório.")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O gênero possui mais de 30 caracteres.")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ter no mínimo 1 e no máximo 600 minutos.")]
        public int Duracao { get; set; }
        public DateTime HoraConsulta { get; set; }
    }
}