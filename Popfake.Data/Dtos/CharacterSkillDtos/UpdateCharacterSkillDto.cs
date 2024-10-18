using System.ComponentModel.DataAnnotations;

namespace PopFake.Data.Dtos;

public class UpdateCharacterSkillDto : BaseDto
{
    public int Level { get; set; }
}
