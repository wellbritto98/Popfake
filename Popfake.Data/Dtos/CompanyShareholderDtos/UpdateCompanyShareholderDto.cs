using System.ComponentModel.DataAnnotations;

namespace PopFake.Data.Dtos;

public class UpdateCompanyShareholderDto : BaseDto
{
    public int Shares { get; set; }
public bool IsPresident { get; set; }
}
