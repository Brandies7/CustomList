using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FirstName<string> firstName = new FirstName<string>();
            firstName.Add("Nico");
            firstName.Add("Autumn");
            firstName.Add("Bailey");
            firstName.Add("Summer");
            firstName.Add("Mason");

        }
    }
}
