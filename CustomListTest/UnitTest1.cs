using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CustomList<string> firstName = new CustomList<string>();
            firstName.Add("Nico");
            firstName.Add("Autumn");
            firstName.Add("Bailey");
            firstName.Add("Summer");
            firstName.Add("Mason");
            string expectedResult = ("Nico");
            string actualResult;

            actualResult = firstName[0];

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]

        public void TestMethod2()
        {
            CustomList<string> firstName = new CustomList<string>();
            firstName.Add("Nico");
            firstName.Add("Autumn");
            firstName.Add("Bailey");
            firstName.Add("Summer");
            firstName.Add("Mason");
            string expectedResult = ("Autumn");
            string actualResult;

            actualResult = firstName[1];

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]

        public void TestMethod3()
        {
            CustomList<string> firstName = new CustomList<string>();
            firstName.Add("Nico");
            firstName.Add("Autumn");
            firstName.Add("Bailey");
            firstName.Add("Summer");
            firstName.Add("Mason");
            string expectedResult = ("Bailey");
            string actualResult;

            actualResult = firstName[2];

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]

        public void TestMethod4()
        {
            CustomList<string> firstName = new CustomList<string>();
            firstName.Add("Nico");
            firstName.Add("Autumn");
            firstName.Add("Bailey");
            firstName.Add("Summer");
            firstName.Add("Mason");
            firstName.Remove("Nico");
            string expectedResult = ("Autumn");
            string actualResult;

            actualResult = firstName[0];

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]

        public void TestMethod5()
        {
            CustomList<string> firstName = new CustomList<string>();
            firstName.Add("Nico");
            firstName.Add("Autumn");
            firstName.Add("Bailey");
            firstName.Add("Summer");
            firstName.Add("Mason");
            firstName.Remove("Autumn");
            string expectedResult = ("Bailey");
            string actualResult;

            actualResult = firstName[1];

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]

        public void TestMethod6()
        {
            CustomList<string> firstName = new CustomList<string>();
            firstName.Add("Nico");
            firstName.Add("Autumn");
            firstName.Add("Bailey");
            firstName.Add("Summer");
            firstName.Add("Mason");
            firstName.Remove("Bailey");
            string expectedResult = ("Summer");
            string actualResult;

            actualResult = firstName[2];

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]

        public void TestMethod7()
        {
            CustomList<string> firstName = new CustomList<string>();
            firstName.Add("Nico");
            firstName.Add("Autumn");
            firstName.Add("Bailey");
            firstName.Add("Summer");
            firstName.Add("Mason");
            firstName.Remove("Summer");
            string expectedResult = ("Mason");
            string actualResult;

            actualResult = firstName[3];

            Assert.AreEqual(expectedResult, actualResult);
        }

        public void TestMethod8()
        {
            CustomList<int> age = new CustomList<int>();
            age.Add(14);
            age.Add(12);
            age.Add(10);
            age.Add(7);
            age.Add(3);
            age.ToString();

            //"1412107"
        }
    }
}




 