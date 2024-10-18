using System.ComponentModel.DataAnnotations;

namespace PopFake.Data.Dtos;

public class InsertCompanyShareholderDto : BaseDto
{
    public int CharacterId { get; set; }
public int CompanyId { get; set; }
public int Shares { get; set; }
public bool IsPresident { get; set; }
}
