using System.ComponentModel.DataAnnotations;

namespace PopFake.Data.Dtos;

public class UpdateCityDto : BaseDto
{
    public string Name { get; set; }
public string Timezone { get; set; }
}
