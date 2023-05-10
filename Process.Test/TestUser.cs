using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_Oefeningen;

namespace Process.Test
{
    [TestFixture]
    public class TestUser
    {
        private User _user;
        [SetUp]
        public void SetUp()
        {
            _user = new User();
        }

        [Test]
        public void CanceledBy()
        {
            var expected = "Admin";
            _user.CanceledBy(expected);
            var result = _user.MadeBy;
            //Assert.That(result, Is.True);
            Assert.That(result,Is.EqualTo(expected));
        }

        [Test]
        [TestCase("Admin",true)]
        [TestCase("Self",true)]
        [TestCase("Other",false)]
        public void CanceledBy(string input,bool output)
        {
            var result = _user.CanceledBy(input);
            Assert.That(result, Is.EqualTo(output));
            //Assert.That(result,Is.True); Work only with true......
        }

    }
}
