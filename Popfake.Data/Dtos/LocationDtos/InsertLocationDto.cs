using System.ComponentModel.DataAnnotations;
using PopFake.Models;

namespace PopFake.Data.Dtos;

public class InsertLocationDto : BaseDto
{
    public string Name { get; set; }
public int Quality { get; set; }
public LocationType TypeId { get; set; }
public int CompanyId { get; set; }
public ulong Money { get; set; }
}
