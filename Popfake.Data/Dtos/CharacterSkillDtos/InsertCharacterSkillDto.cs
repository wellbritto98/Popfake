using System.ComponentModel.DataAnnotations;

namespace PopFake.Data.Dtos;

public class InsertCharacterSkillDto : BaseDto
{
    public int CharacterId { get; set; }
public int SkillId { get; set; }
public int Level { get; set; }
}
