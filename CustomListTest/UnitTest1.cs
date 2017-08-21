﻿using CustomListProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            string actualResult = firstName[0];

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
            string actualResult = firstName[2];

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
            age.Add("14");
            age.Add("12");
            age.Add("10");
            age.Add("7");
            age.Add("3");

            string actualResult = age.ToString();
            string expectedResult = "14121073";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod9()
        {
            CustomList<int> age = new CustomList<int>();
            age.Add("14");
            age.Add("12");
            age.Add("10");
            age.Add("7");
            age.Add("3");
            age.ToString();

            string actualResult = "1";
            string expectedResult = age[0];

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod10()
        {
            CustomList<int> age = new CustomList<int>();
            age.Add("14");
            age.Add("12");
            age.Add("10");
            age.Add("7");
            age.Add("3");
            age.ToString();

            string actualResult = "4";
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

            age.Add("14");
            age.Add("12");
            age.Add("10");
            age.Add("7");
            age.Add("3");

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

            age.Add("14");
            age.Add("12");
            age.Add("10");
            age.Add("7");
            age.Add("3");

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

            age.Add("14");
            age.Add("12");
            age.Add("10");
            age.Add("7");
            age.Add("3");

            kidsAge = firstName + age;

            string expectedResult = "10";
            string actualResult = kidsAge[7];

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod14()
        {
            CustomList<string> firstName = new CustomList<string>();
            CustomList<string> age = new CustomList<string>();
            CustomList<string> kidsAge = new CustomList<string>();

            firstName.Add("Nico");
            firstName.Add("Autumn");
            firstName.Add("Bailey");
            firstName.Add("Summer");
            firstName.Add("Mason");
            firstName.Add("Nico");
            firstName.Add("Nico");

            age.Add("14");
            age.Add("12");
            age.Add("10");
            age.Add("7");
            age.Add("3");
            age.Add("12");
            age.Add("12");

            kidsAge = firstName + age;
            kidsAge - ("12");
            kidsAge - ("Nico");
        }

        [TestMethod]
        public void TestMethod15()
        {
            CustomList<string> firstName = new CustomList<string>();
            CustomList<string> age = new CustomList<string>();
            CustomList<string> kidsAge = new CustomList<string>();

            firstName.Add("Nico");
            firstName.Add("Autumn");
            firstName.Add("Bailey");
            firstName.Add("Summer");
            firstName.Add("Mason");
            firstName.Add("Bailey");
            firstName.Add("Bailey");

            age.Add("14");
            age.Add("12");
            age.Add("10");
            age.Add("7");
            age.Add("3");
            age.Add("10");
            age.Add("10");

            kidsAge = firstName + age;
            kidsAge - ("10");
            kidsAge - ("Bailey");
        }

        [TestMethod]
        public void TestMethod16()
        {
            CustomList<string> firstName = new CustomList<string>();
            CustomList<string> age = new CustomList<string>();
            CustomList<string> kidsAge = new CustomList<string>();

            firstName.Add("Nico");
            firstName.Add("Autumn");
            firstName.Add("Bailey");
            firstName.Add("Summer");
            firstName.Add("Mason");

            age.Add("14");
            age.Add("12");
            age.Add("10");
            age.Add("7");
            age.Add("3");

            kidsAge = firstName.Zip(age);

            string expectedResult = ("Nico", "14", "Autumn", "12", "Bailey", "10", "Summer", "10", "Mason", "3");
            string actualResult = kidsAge();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod17()
        {
            CustomList<string> firstName = new CustomList<string>();
            CustomList<string> age = new CustomList<string>();
            CustomList<string> kidsAge = new CustomList<string>();

            firstName.Add("Nico");
            firstName.Add("Autumn");
            firstName.Add("Bailey");
            firstName.Add("Summer");
            firstName.Add("Mason");

            age.Add("14");
            age.Add("12");
            age.Add("10");
            age.Add("7");
            age.Add("3");

            kidsAge = firstName.Zip(age);

            string expectedResult = "Nico";
            string actualResult = kidsAge[0];

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod18()
        {
            CustomList<string> firstName = new CustomList<string>();
            CustomList<string> age = new CustomList<string>();
            CustomList<string> kidsAge = new CustomList<string>();

            firstName.Add("Nico");
            firstName.Add("Autumn");
            firstName.Add("Bailey");
            firstName.Add("Summer");
            firstName.Add("Mason");

            age.Add("14");
            age.Add("12");
            age.Add("10");
            age.Add("7");
            age.Add("3");

            kidsAge = firstName.Zip(age);

            string expectedResult = "12";
            string actualResult = kidsAge[3];

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}