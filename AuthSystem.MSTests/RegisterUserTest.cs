using AuthSystem.Areas.Identity.Pages.Account;
using System.Diagnostics;

namespace AuthSystem.MSTests
{
    [TestClass]
    public class RegisterUserTest
    {
        #region UserEmailValidation

        [TestMethod]
        public void IsValidEmail_Success()
        {
            var validEmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa!";
            var watch = new Stopwatch();
            watch.Start();
            Assert.IsFalse(RegisterModel.IsValidEmail(validEmailAddress));
            watch.Stop();
            Console.WriteLine("Elapsed time {0}ms", watch.ElapsedMilliseconds);
            watch.Reset();
        }

        #endregion
    }
}