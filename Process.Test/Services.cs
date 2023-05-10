using UnitTest_Oefeningen;
using NUnit.Framework;
using System.Globalization;

namespace Process.Test
{
    [TestFixture]
    public class Services
    {
        UnitTest_Oefeningen.Process _process;
        [SetUp]
        
        public void Setup()
        {
            _process=new UnitTest_Oefeningen.Process();
        }

        [Test]
        public void SayHallo_SentNaam_Return_HalloNaam()
        {
            string expected = "Hallo, Kenan!";
            string result= _process.SayHallo("Kenan");
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(4,2,4)]
        [TestCase(8,2,8)]
       // [TestCase(4,5,4)]
        public void GetMax_Give_Two_Number_Return_Max( int num1,int num2,int output)
        {
            var result = _process.GetMax(num1, num2);
            Assert.That (result, Is.EqualTo(output));
        }

        [Test]
        [TestCase(4, 2, 4, true)]
        [TestCase(8, 2, 8, true)]
        public void GetMaxValue_Give_Two_Number_Return_Max(int num1, int num2, int output, bool outcoms)
        {
            var result = _process.GetMaxvalue(num1, num2);
            Assert.That(result, Is.EqualTo(outcoms));
        }


        [Test]  
         [TestCase(4, 5, 4, false)]
        public void GetMaxValue_Give_Two_Number_Return(int num1, int num2, int output, bool outcoms)
        {
            var result = _process.GetMaxvalue(num1, num2);
            Assert.That(result, Is.Not.EqualTo(outcoms));
        }


        [Test]
        public void Getname_SentNaam_Return_Naam()
        {
            string expected = "Kenan";
            _process.GetNameVoid("Kenan");
            string result = _process.Name;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Getname_List_Return_Naams()
        {
            _process.GetStringList("Kenan");
            Assert.That(_process.NameList.Contains("Kenan"));
        }

        [Test]
        public void ReversedNumber()
        {
            var expected = 321;
            var result = _process.ReverseNumber(123);
            Assert.That(result,Is.EqualTo(expected));
        }

        [Test]
        [TestCase("pop",true)]
        [TestCase("lepel",true)]
        [TestCase("Lepel",true)]
        [TestCase("vork",false)]
        public void PalindromString(string input,bool output)
        {
            var result = _process.PalindromString(input);
            Assert.That(result, Is.EqualTo(output));
        }


        [Test]
        [TestCase("08:00:00","Good Morning!")]
        [TestCase("12:00:00", "Good Day!")]
        [TestCase("18:00:00", "Good Evening!")]
        [TestCase("23:59:00", "Good Night!")]
        public void StringGreeting(string input,string expected)
        {
            var time = DateTime.ParseExact(input, "HH:mm:ss", CultureInfo.InvariantCulture);
            var result = _process.StringGreeting(time);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(458,"Eight")]
        [TestCase(45,"Five")]
        [TestCase(120,"Zero")]

        public void Read_SentInt_Back_LastnumInString(int input,string output)
        {
            var result = _process.Read_Last_Number(input);
            Assert.That(result, Is.EqualTo(output));
        }

        //[Test]
        //public void CountRepetedNumberInArray()
        //{
        //    var expected = 2;
        //    var result=_process.Count_HoeveelKeer_InArray(new int[] {1,2,3,4,4,5});
        //    Assert.That(result,Is.EqualTo(expected));
        //}

    }
}