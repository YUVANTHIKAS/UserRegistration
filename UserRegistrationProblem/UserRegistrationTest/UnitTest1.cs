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
            string input = "Sarathy";
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
            string input = "yuvanthika@gmail.com";
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
            string input = "Yuvanthika@1234";
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
            string input = "Yuvanthika07";
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
            string input = "Yuvanthika1234";
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
            string input = "Yuvanthika@1234";
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
        [Test]
        public void TestAllTrueEmails()
        {
            string[] input = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com",
                "abc-100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            Validate trueEmails = new Validate();
            foreach (var item in input)
            {
                bool result = trueEmails.ValidateEmail(item);
                Assert.IsTrue(result);
            }
        }
        [Test]
        public void TestFirstNameRegex()
        {
            string input = "Yuvanthika";
            Validate firstName = new Validate();
            bool result = firstName.ValidateFirstNameRegex(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestLastNameRegex()
        {
            string input = "Sarathy";
            Validate lastName = new Validate();
            bool result = lastName.ValidateLastNameRegex(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestEmailRegex()
        {
            string input = "Yuvanthika@gmail.com";
            Validate email = new Validate();
            bool result = email.ValidateEmailRegex(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestPhoneNumberRegex()
        {
            string input = "91 9012345678";
            Validate phonenumber = new Validate();
            bool result = phonenumber.ValidatePhoneNumberRegex(input);
            Assert.IsTrue(result);
        }
        [Test]
        public void TestPasswordRegex()
        {
            string input = "Yuvanthika@1234";
            Validate password = new Validate();
            bool result = password.ValidatePasswordRegex(input);
            Assert.IsTrue(result);
        }
    }
}