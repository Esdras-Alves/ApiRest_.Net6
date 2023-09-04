using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O título do filme não deve exceder 50 caracteres")]
    public string? Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [StringLength(25, ErrorMessage = "O gênero do filme não deve exceder 25 caracteres")]
    public string? Genero { get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatória")]
    [Range(70, 600, ErrorMessage = "A duração deve ser entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
