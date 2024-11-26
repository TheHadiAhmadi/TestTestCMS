namespace TestTestCMS.Providers.ApiTokenProviders;

public interface IApiTokenProvider
{
    public string GenerateKey();
    public string GenerateSecret(string apiKey);
    public bool Validate(string apiKey, string secretKey);
}
