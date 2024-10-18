using PopFake.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PopFake.Models;

public class Location : BaseEntity 
{
[Key, Column(Order = 0)]
public int Id { get; set; }
public string Name { get; set; }
public int Quality { get; set; } = 0;
public LocationType TypeId { get; set; }
public virtual LocationType Type { get; set; }
[ForeignKey("Company")]
public int CompanyId { get; set; }
public virtual Company Company { get; set; }
public ulong Money { get; set; } = 0;

public virtual ICollection<Character> Characters { get; set; }
}
