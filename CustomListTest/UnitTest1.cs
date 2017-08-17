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

        [TestMethod]

        public void TestMethod8()
        {
            CustomList<string> age = new CustomList<string>();
            age.Add("fourteen");
            age.Add("twelve");
            age.Add("ten");
            age.Add("seven");
            age.Add("three");

            string actualResult = age.ToString();
            string expectedResult = "fourteentwelvetenseventhree";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]

        public void TestMethod9()
        {
            CustomList<int> age = new CustomList<int>();
            age.Add("fourteen");
            age.Add("twelve");
            age.Add("ten");
            age.Add("seven");
            age.Add("three");
            age.ToString();

            string actualResult = "f";
            string expectedResult = age[0];

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]

        public void TestMethod10()
        {
            CustomList<int> age = new CustomList<int>();
            age.Add("fourteen");
            age.Add("twelve");
            age.Add("ten");
            age.Add("seven");
            age.Add("three");
            age.ToString();

            string actualResult = "o";
            string expectedResult = age[1];

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        
        public void TestMethod11()
        {
            CustomList<string> firstName = new CustomList<string>();
            CustomList<string> age = new CustomList<string>();
            CustomList<string> kidsAge = new CustomList<string>();

            firstName.Add("Nico");
            firstName.Add("Autumn");
            firstName.Add("Bailey");
            firstName.Add("Summer");
            firstName.Add("Mason");

            age.Add("fourteen");
            age.Add("twelve");
            age.Add("ten");
            age.Add("seven");
            age.Add("three");
            
            kidsAge = firstName + age;

            string expectedResult = "Bailey";
            string actualResult = firstName[2];

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]

        public void TestMethod12()
        {
            CustomList<string> firstName = new CustomList<string>();
            CustomList<string> age = new CustomList<string>();
            CustomList<string> kidsAge = new CustomList<string>();

            firstName.Add("Nico");
            firstName.Add("Autumn");
            firstName.Add("Bailey");
            firstName.Add("Summer");
            firstName.Add("Mason");

            age.Add("fourteen");
            age.Add("twelve");
            age.Add("ten");
            age.Add("seven");
            age.Add("three");

            kidsAge = firstName + age;

            string expectedResult = "Mason";
            string actualResult = firstName[4];

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]

        public void TestMethod13()
        {
            CustomList<string> firstName = new CustomList<string>();
            CustomList<string> age = new CustomList<string>();
            CustomList<string> kidsAge = new CustomList<string>();

            firstName.Add("Nico");
            firstName.Add("Autumn");
            firstName.Add("Bailey");
            firstName.Add("Summer");
            firstName.Add("Mason");

            age.Add("fourteen");
            age.Add("twelve");
            age.Add("ten");
            age.Add("seven");
            age.Add("three");

            kidsAge = firstName + age;

            string expectedResult = "ten";
            string actualResult = firstName[7];

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]

        public void TestMethod14()
        {

        }

    }
}
            

           





 