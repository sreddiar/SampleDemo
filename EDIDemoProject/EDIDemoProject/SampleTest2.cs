using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace EDIDemoProject
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod()
        {
            Assert.IsTrue(BaseLibrary.FileOperation.CopyFile(@"C:\Users\chuck\Desktop\Projects\CaptureRX\source",
                        @"C:\Users\chuck\Desktop\Projects\CaptureRX\target",
                        "test.txt"));
        }



    }
}
