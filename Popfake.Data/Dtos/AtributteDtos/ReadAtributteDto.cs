using System.ComponentModel.DataAnnotations;

namespace PopFake.Data.Dtos;

public class ReadAtributteDto : BaseDto
{
    public int Id { get; set; }
public string Name { get; set; }
public string Description { get; set; }
}
