using UserRegistration;

namespace UserRegistrationTest
{
    public class Tests
    {

        [Test]
        public void TestFirstName()
        {
            string input = "Riya";
            Validate firstName = new Validate();
            bool result = firstName.ValidateFirstName(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestLastName()
        {
            string input = "Reji";
            Validate lastName = new Validate();
            bool result = lastName.ValidateLastName(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestEmail()
        {
            string input = "riyareji@gmail.com";
            Validate email = new Validate();
            bool result = email.ValidateEmail(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestPhoneNumber()
        {
            string input = "91 9012345678";
            Validate phonenumber = new Validate();
            bool result = phonenumber.ValidatePhoneNumber(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestCheckCharacter()
        {
            string input = "riya@1234";
            Validate character = new Validate();
            bool result = character.ValidateCheckCharacter(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestUpperCase()
        {
            string input = "Riya1234";
            Validate uppercase = new Validate();
            bool result = uppercase.ValidateUpperCase(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestNumeric()
        {
            string input = "Riya1234";
            Validate numeric = new Validate();
            bool result = numeric.ValidateNumeric(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
        [Test]
        public void TestSpecialCharacter()
        {
            string input = "Riya@1234";
            Validate special = new Validate();
            bool result = special.ValidateSpecialCharacter(input);
            string value = "";
            if (result)
            {
                value = "HAPPY";
            }
            else
            {
                value = "SAD";
            }
            Assert.AreEqual(value, "HAPPY");
        }
    }
}