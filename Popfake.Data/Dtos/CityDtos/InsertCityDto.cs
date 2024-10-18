using System.ComponentModel.DataAnnotations;

namespace PopFake.Data.Dtos;

public class InsertCityDto : BaseDto
{
    public string Name { get; set; }
public string Timezone { get; set; }
}
