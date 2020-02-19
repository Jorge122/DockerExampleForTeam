using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using DockerExampleForTeam.Pages;
using Microsoft.Extensions.Logging;

namespace DockerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            
            IndexModel test = new IndexModel();
            var num = test.Add(10, 5);
            Assert.AreEqual(num, 15);
        }
    }
}