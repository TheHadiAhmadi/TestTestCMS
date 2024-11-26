namespace TestTestCMS.Entities;

public class UserTwoFactorRecoveryCode
{
    public required string Code { get; set; }
    public bool Redeemed { get; set; }
}
