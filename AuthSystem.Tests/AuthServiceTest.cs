using AuthSystem.Areas.Identity.Pages.Account;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace AuthSystem.Tests
{
    [TestClass]
    public class AuthServiceTest
    {
        const string EmailRegex = @"^([a-zA-Z0-9]+[_\.\-]?)*[a-zA-Z0-9]+@([a-zA-Z0-9]+[\.\-]?)*[a-zA-Z0-9]+\.[a-zA-Z]{2,4}$";

        #region RegisterUser

        [TestMethod]
        public void IsValidEmail_Success()
        {
            var validEmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa!";
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