using System.ComponentModel.DataAnnotations;

namespace PopFake.Data.Dtos;

public class InsertAtributteDto : BaseDto
{
    public string Name { get; set; }
public string Description { get; set; }
}
