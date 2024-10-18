using System.ComponentModel.DataAnnotations;

namespace PopFake.Data.Dtos;

public class UpdateAtributteDto : BaseDto
{
    public string Name { get; set; }
public string Description { get; set; }
}
