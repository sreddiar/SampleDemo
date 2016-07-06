using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace EDIDemoProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(BaseLibrary.FileOperation.CopyFile(@"C:\Users\chuck\Desktop\Projects\CaptureRX\source",
                        @"C:\Users\chuck\Desktop\Projects\CaptureRX\target",
                        "test.txt"));
        }



    }
}