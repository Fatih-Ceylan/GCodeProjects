using System.Security.Cryptography;
using System.Text;
using Utilities.Core.UtilityApplication.Abstractions.Sha256;

namespace Utilities.Infrastructure.UtilityInfrastructure.Services.Sha256
{
    public class Sha256Service : ISha256Service
    {
        public string PasswordEncrypt(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public string GenerateUniqueCode()
        {
            var currentTime = DateTime.UtcNow;
            string timeString = currentTime.ToString("yyyyMMddHHmmssffff");

            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(timeString));
                StringBuilder hexString = new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    hexString.Append(b.ToString("X2"));
                }

                string uniqueCode = hexString.ToString().Substring(0, 20);

                return uniqueCode;
            }
        }
    }
}
