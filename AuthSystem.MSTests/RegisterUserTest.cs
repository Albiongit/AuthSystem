using AuthSystem.Areas.Identity.Pages.Account;
using System.Diagnostics;

namespace AuthSystem.MSTests
{
    [TestClass]
    public class RegisterUserTest
    {
        //Number of random strings to generte.
        const int maxIterations = 10000;

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

        [TestMethod]
        public void Fuzz_EmailAddress()
        {
            //Testing maxIterations times
            for (int index = 0; index < maxIterations; index++)
            {
                //Generating a random string
                var fuzzInput = GenerateRandomString(index * 5);
                var sw = new Stopwatch();
                sw.Start();
                Assert.IsFalse(RegisterModel.IsValidEmail(fuzzInput));
                //Elapsed time should be less than 3 seconds per input.
                Assert.IsTrue(sw.Elapsed.Seconds < 3);
            }
        }

        public static string GenerateRandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new char[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = chars[random.Next(chars.Length)];
            }
            return new string(result);
        }

        #endregion
    }
}