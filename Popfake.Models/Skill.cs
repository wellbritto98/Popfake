using PopFake.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PopFake.Models;

public class Skill : BaseEntity 
{
[Key, Column(Order = 0)]
public int Id { get; set; }
public string Name { get; set; }
public string Description { get; set; }
public virtual ICollection<CharacterSkill> CharacterSkills { get; set; }
}
