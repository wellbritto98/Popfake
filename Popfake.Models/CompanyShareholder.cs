using Microsoft.EntityFrameworkCore;
using PopFake.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PopFake.Models;
[PrimaryKey(nameof(CharacterId), nameof(CompanyId))]
public class CompanyShareholder : BaseEntity 
{
[Column(Order = 0)]
[ForeignKey("Character")]
public int CharacterId { get; set; }
public virtual Character Character { get; set; }
[Column(Order = 1)]
[ForeignKey("Company")]
public int CompanyId { get; set; }
public virtual Company Company { get; set; }
public int Shares { get; set; }
public bool IsPresident { get; set; } = false;
}
