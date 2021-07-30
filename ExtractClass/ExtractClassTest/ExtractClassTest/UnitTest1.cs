using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtractClassTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var person = new Person();
            person.SetOfficeAreaCode("02");
            person.SetOfficeNumber("2222-2222");

            var telePhoneNumber = person.GetTelePhoneNumber();

            telePhoneNumber.Should().Be("022222-2222");
        }
    }
}
