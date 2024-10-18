using System.ComponentModel.DataAnnotations;

namespace PopFake.Data.Dtos;

public class InsertCompanyDto : BaseDto
{
    public string Name { get; set; }
public int CityId { get; set; }
public CompanyType CompanyType { get; set; }
public ulong Money { get; set; }
}
