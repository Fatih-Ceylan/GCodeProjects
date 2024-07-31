namespace Utilities.Core.UtilityApplication.Abstractions.Sha256
{
    public interface ISha256Service
    {
        string PasswordEncrypt(string password);
        string GenerateUniqueCode();
    }
}
