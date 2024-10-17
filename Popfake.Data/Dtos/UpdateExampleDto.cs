using System.ComponentModel.DataAnnotations;

namespace PopFake.Data.Dtos;

public class UpdateExampleDto : BaseDto
{

    [Required]
    public string Name { get; set; }
    [Required]
    public string Nickname { get; set; }

}