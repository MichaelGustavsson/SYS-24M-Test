namespace Application.DTOs;

public class AccountDto : BaseAccountDto
{
    public string Id { get; set; } = "";
    public bool IsBlocked { get; set; } = false;
    public override string ToString()
    {
        return $"{AccountNumber} {CreatedDate} {Owner}";
    }
}
