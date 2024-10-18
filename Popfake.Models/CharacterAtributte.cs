using Microsoft.EntityFrameworkCore;
using PopFake.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PopFake.Models;
[PrimaryKey(nameof(CharacterId), nameof(AtributteId))]
public class CharacterAtributte : BaseEntity 
{
[Key, Column(Order = 0)]
[ForeignKey("Character")]
public int CharacterId { get; set; }
public virtual Character Character { get; set; }
[Key, Column(Order = 1)]
[ForeignKey("Atributte")]
public int AtributteId { get; set; }
public virtual Atributte Atributte { get; set; }
public int Level { get; set; }
}
