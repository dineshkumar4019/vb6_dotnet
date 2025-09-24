using System;
namespace LegacyService.Tests {
    public class UserServiceTests {
        public void TestNormalize() {
            var svc = new LegacyService.UserService();
            var res = svc.Normalize(" alice ");
            if (res != "ALICE") throw new Exception("Normalize failed");
        }

        // Test that demonstrates weak password hashing acceptance
        public void TestWeakHash() {
            var svc = new LegacyService.UserService();
            var hash = svc.HashPassword("password");
            if (string.IsNullOrEmpty(hash)) throw new Exception("Hash returned empty");
        }
    }
}
