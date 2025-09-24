using System;
namespace LegacyService.Tests {
    public class UserServiceTests {
        public void TestNormalize() {
            var svc = new LegacyService.UserService();
            var res = svc.Normalize(" alice ");
            if (res != "ALICE") throw new Exception("Normalize failed");
        }
    }
}
