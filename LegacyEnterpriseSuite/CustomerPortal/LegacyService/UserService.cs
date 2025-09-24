using System;
namespace LegacyService {
    public class UserService {
        public string Normalize(string name) {
            return name.Trim().ToUpperInvariant();
        }
    }
}
