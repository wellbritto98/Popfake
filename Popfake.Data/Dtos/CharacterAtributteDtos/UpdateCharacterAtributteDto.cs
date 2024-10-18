using System.ComponentModel.DataAnnotations;

namespace PopFake.Data.Dtos;

public class UpdateCharacterAtributteDto : BaseDto
{
    public int Level { get; set; }
}
