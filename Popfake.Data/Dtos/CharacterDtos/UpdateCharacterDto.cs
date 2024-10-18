using System.ComponentModel.DataAnnotations;

namespace PopFake.Data.Dtos;

public class UpdateCharacterDto : BaseDto
{
    public string FirstName { get; set; }
public string LastName { get; set; }
public int Age { get; set; }
public string Gender { get; set; }
public DateTime? BirthAt { get; set; }
public int BirthCityId { get; set; }
public int CurrentLocationId { get; set; }
public ulong Money { get; set; }
}
