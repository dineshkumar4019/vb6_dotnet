using System;
using System.Text;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace LegacyService {
    public class UserService {
        public string Normalize(string name) {
            return name.Trim().ToUpperInvariant();
        }

        // Insecure hashing: MD5 (weak) + no salt
        public string HashPassword(string password) {
            using (var md5 = MD5.Create()) {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hash = md5.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        // Vulnerable SQL via concatenation (SQL Injection)
        public void FindByEmail(string email, string connectionString) {
            var query = "SELECT * FROM Customers WHERE Email='" + email + "'"; // vulnerable
            using (var conn = new SqlConnection(connectionString)) {
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                var rdr = cmd.ExecuteReader();
                // process...
            }
        }

        // Hardcoded API key
        public string GetApiKey() {
            return "APIKEY-SECRET-123456"; // hardcoded secret
        }

        // Use of obsolete crypto (DES)
        public byte[] EncryptWithDES(string plain, byte[] key, byte[] iv) {
            using (var des = new DESCryptoServiceProvider()) {
                var encryptor = des.CreateEncryptor(key, iv);
                var input = Encoding.UTF8.GetBytes(plain);
                return encryptor.TransformFinalBlock(input, 0, input.Length);
            }
        }
    }
}
