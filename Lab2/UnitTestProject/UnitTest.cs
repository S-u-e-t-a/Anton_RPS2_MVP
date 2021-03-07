using System;
using Lab2.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2.Presenters;
using Lab2.Views;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodAtbashUsualText()
        {
            string text = "Привет, Мир!";
            string expected = "Поцэъм, Тцо!";
            var atbash = new Atbash();
            Assert.AreEqual(expected, atbash.Encode(text));
        }

        [TestMethod]
        public void TestMethodAtbashNumbers()
        {
            string text = "Привет123!";
            string expected = "Поцэъм123!";
            var atbash = new Atbash();
            Assert.AreEqual(expected, atbash.Encode(text));
        }

        [TestMethod]
        public void TestMethodAtbashDecodeUsual()
        {
            string text = "Поцэъм, Тцо!";
            string expected = "Привет, Мир!";
            var atbash = new Atbash();
            Assert.AreEqual(expected, atbash.Decode(text));
        }

        [TestMethod]
        public void TestMethodRot13Usual()
        {
            string text = "Привет, Мир!123";
            string expected = "Ьэхося, Щхэ!123";
            var rot13 = new ROT13();
            Assert.AreEqual(expected, rot13.Encode(text));
        }

        [TestMethod]
        public void TestMethodRot13Decode()
        {
            string text = "Ьэхося, Щхэ!123";
            string expected = "Привет, Мир!123";
            var rot13 = new ROT13();
            Assert.AreEqual(expected, rot13.Decode(text));
        }
    }
}
