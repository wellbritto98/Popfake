using PopFake.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PopFake.Models;

public class City : BaseEntity 
{
[Key, Column(Order = 0)]
public int Id { get; set; }
public string Name { get; set; }
public string Timezone { get; set; }

public ICollection<Company> Companies { get; set; }
}
