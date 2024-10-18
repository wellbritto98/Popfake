using System.ComponentModel.DataAnnotations;

namespace PopFake.Data.Dtos;

public class InsertCharacterAtributteDto : BaseDto
{
    public int CharacterId { get; set; }
public int AtributteId { get; set; }
public int Level { get; set; }
}
