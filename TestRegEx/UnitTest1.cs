using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegExp;

namespace TestRegEx
{
    [TestClass]
    public class UnitTest1
    {
        Pattern pattern = new Pattern();
        /// <summary>
        /// Tests the first name
        /// </summary>
        [TestMethod]
        public string TestFirstName()
        {
            string result = pattern.IsValidFirstName();
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Tests the last name
        /// </summary>
        [TestMethod]
        public void TestLastName()
        {
            bool result1 = pattern.validateLastName("Chaudhari");
            Assert.IsTrue(result1);
        }
        /// <summary>
        /// Tests the Email ID
        /// </summary>
        [TestMethod]
        public void TestEmail()
        {
            bool result2 = pattern.validateEmailId("spchaudhari80@gmail.com");
            Assert.IsTrue(result2);
        }
        /// <summary>
        /// Tests the mobile number
        /// </summary>
        [TestMethod]
        public void TestMobileNumber()
        {
            bool result3 = pattern.validatePhoneNumber("9862583253");
            Assert.IsTrue(result3);
        }
        /// <summary>
        /// Test passwords
        /// </summary>
        [TestMethod]
        public void Testpassword()
        {
            bool result4 = pattern.validatePassWord("Samik@chau80");
            Assert.IsTrue(result4);
        }
    }
}
