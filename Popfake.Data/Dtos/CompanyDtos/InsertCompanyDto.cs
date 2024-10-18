using System.ComponentModel.DataAnnotations;
using PopFake.Models;

namespace PopFake.Data.Dtos;

public class InsertCompanyDto : BaseDto
{
    public string Name { get; set; }
public int CityId { get; set; }
public CompanyType CompanyType { get; set; }
public ulong Money { get; set; }
}
