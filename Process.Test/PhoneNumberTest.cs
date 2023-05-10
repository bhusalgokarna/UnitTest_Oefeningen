using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_Oefeningen;

namespace Process.Test
{
    [TestFixture]
    public class PhoneNumberTest
    {
        [Test]

        [TestCase("214566785235")]
        [TestCase("042536")]
       // [TestCase("0485194632")]

        public void PhoneNumber_IsLength_Correct(string input)
        {
           // Assert.That(() => _services.Division(2, 0), Throws.TypeOf<DivideByZeroException>());
            Assert.That(()=>PhoneNumber.Parse(input), Throws.ArgumentException);
        }

        [Test]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("\n")]
        [TestCase("\t")]
        [TestCase(null)]
        public void PhoneNumber_Has_NullOrWhiteSpaces_Return_Exception(string input)
        {
            Assert.That(() => PhoneNumber.Parse(input), Throws.ArgumentException);
        }
    }
}
