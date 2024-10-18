using System.ComponentModel.DataAnnotations;

namespace PopFake.Data.Dtos;

public class ReadCompanyDto : BaseDto
{
    public int Id { get; set; }
public string Name { get; set; }
public int CityId { get; set; }
public CompanyType CompanyType { get; set; }
public ulong Money { get; set; }
}
