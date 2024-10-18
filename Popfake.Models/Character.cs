using PopFake.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PopFake.Models;

public class Character : BaseEntity 
{
[Key, Column(Order = 0)]
public int Id { get; set; }
[ForeignKey("User")]
public string UserId { get; set; }
public virtual User User { get; set; }
public string FirstName { get; set; }
public string LastName { get; set; }
public int Age { get; set; }
public string Gender { get; set; }
public DateTime BirthAt { get; set; } = DateTime.Now;
[ForeignKey("City")]
public int BirthCityId { get; set; } = 1;
public virtual City BirthCity { get; set; }
[ForeignKey("Location")]
public int CurrentLocationId { get; set; } = 1;
public virtual Location CurrentLocation { get; set; }
public ulong Money { get; set; } = 0;

public virtual ICollection<CompanyShareholder> CompanyShareholders { get; set; }
public virtual ICollection<CharacterSkill> CharacterSkills { get; set; }
public virtual ICollection<CharacterAttribute> CharacterAttributes { get; set; }
}
