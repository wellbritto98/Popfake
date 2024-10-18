using PopFake.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PopFake.Models;

public class Company : BaseEntity 
{
[Key, Column(Order = 0)]
public int Id { get; set; }
public string Name { get; set; }
[ForeignKey("City")]
public int CityId { get; set; }
public virtual City City { get; set; }
public CompanyType CompanyType { get; set; }
public ulong Money { get; set; } = 0;
public virtual ICollection<Location> Locations { get; set; }
}
