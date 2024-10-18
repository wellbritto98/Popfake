using System.ComponentModel.DataAnnotations;

namespace PopFake.Data.Dtos;

public class ReadCityDto : BaseDto
{
    public int Id { get; set; }
public string Name { get; set; }
public string Timezone { get; set; }
}
