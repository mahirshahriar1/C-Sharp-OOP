using Iteration2;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;


namespace IdentifiableObjectTest
{
    public class IdentifiableObjectTests
    {
        private IdentifiableObject _obj;
        private string _name;
        private string[] _arr;

        [SetUp]
        public void Setup()
        {
            _name = "Mahir";
            _arr = new string[] { "abc", "xyz" };
            _obj = new IdentifiableObject(_arr); ////
            _obj.AddIdentifier(_name);
        }


        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(_obj.AreYou("mahir"));
        }
        [Test]
        public void TestNotAreYou()
        {
            Assert.IsFalse(_obj.AreYou("maaahir"));
        }
        [Test]
        public void TestCaseNotSensitive()
        {
            Assert.IsTrue(_obj.AreYou("AbC"));
        }






    }
}