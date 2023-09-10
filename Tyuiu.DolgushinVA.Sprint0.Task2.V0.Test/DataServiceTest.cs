using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DolgushinVA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.DolgushinVA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Вадим";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Вадим", res);
        }
    }
}
