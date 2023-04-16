using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace Module._16.UnitTesting.Tests
{
    public class FileWorkerTests
    {
        [Fact]
        public void GetSafeFilenameMustReturnCorrectValue()
        {
            var fileWorkerTest = new FileWorker();
            PrivateObject obj = new PrivateObject(fileWorkerTest);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Folder________Name_", obj.Invoke("GetSafeFilename", @"Folder:?<>*/\_Name:"));

        }
    }
}
