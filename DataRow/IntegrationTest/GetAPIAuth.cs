using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRow.IntegrationTest
{
    [TestClass]
    public class GetAPIAuth
    {
        [TestMethod]
        [DataRow(10,20,DisplayName ="addition")]
        [DataRow(30,40,DisplayName ="Multiplaction")]
        public void MyFirstTest(int a, int b) 
        {
            Console.WriteLine($"MyFirstTest{a}{b}");
            //Test2
        }
    }
}
