using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace EDIDemoProject
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(BaseLibrary.FileOperation.CopyFile(@"C:\Users\chuck\Desktop\Projects\CaptureRX\source",
                        @"C:\Users\chuck\Desktop\Projects\CaptureRX\target",
                        "test.txt"));
            Assert.IsTrue(BaseLibrary.FileOperation.CopyFile(@"C:\Users\chuck\Desktop\Projects\CaptureRX\source",
                        @"C:\Users\chuck\Desktop\Projects\CaptureRX\target",
                        "test.txt"));
            Assert.IsFalse(BaseLibrary.FileOperation.CopyFile(@"C:\Users\chuck\Desktop\Projects\CaptureRX\source",
                        @"C:\Users\chuck\Desktop\Projects\CaptureRX\target",
                        "test.txt"));
            Assert.IsTrue(BaseLibrary.FileOperation.CopyFile(@"C:\Users\chuck\Desktop\Projects\CaptureRX\source",
                        @"C:\Users\chuck\Desktop\Projects\CaptureRX\target",
                        "test.txt"));
        }



    }
}

