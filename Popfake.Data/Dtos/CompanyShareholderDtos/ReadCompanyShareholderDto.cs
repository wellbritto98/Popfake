using System.ComponentModel.DataAnnotations;

namespace PopFake.Data.Dtos;

public class ReadCompanyShareholderDto : BaseDto
{
    public int CharacterId { get; set; }
public int CompanyId { get; set; }
public int Shares { get; set; }
public bool IsPresident { get; set; }
}
