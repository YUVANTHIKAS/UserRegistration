using UserRegistration;

namespace UserRegistrationTest
{
    public class Tests
    {

        [Test]
        public void TestFirstName()
        {
            string input = "Yuvanthika";
            Validate firstName = new Validate();
            bool result = firstName.FirstName(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestLastName()
        {
            string input = "Sarathy";
            Validate lastName = new Validate();
            bool result = lastName.LastName(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestEmail()
        {
            string input = "yuvanthikasarathy@gmail.com";
            Validate email = new Validate();
            bool result = email.Email(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestPhoneNumber()
        {
            string input = "91 9012345678";
            Validate phonenumber = new Validate();
            bool result = phonenumber.PhoneNumber(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestCheckCharacter()
        {
            string input = "yuva@1234";
            Validate character = new Validate();
            bool result = character.CheckCharacter(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestUpperCase()
        {
            string input = "Yuva1234";
            Validate uppercase = new Validate();
            bool result = uppercase.UpperCase(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestNumeric()
        {
            string input = "Yuva1234";
            Validate numeric = new Validate();
            bool result = numeric.Numeric(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestSpecialCharacter()
        {
            string input = "yuvaS@1234";
            Validate special = new Validate();
            bool result = special.SpecialCharacter(input);
            Assert.IsTrue(result);
        }
    }
}