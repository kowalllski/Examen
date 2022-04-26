using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLib;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Task> task = new List<Task>();
            TaskList taskList = new TaskList("Входящие", task);

            Assert.AreEqual(taskList.GetName(), "Входящие");
        }
    }
}
