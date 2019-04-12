using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Note.FileUtils;

//USE THIS NAMESPACE FOR TESTING METHODS
namespace UtilitiesUnitTest
{
    [TestClass]
    public class FileUtilsTest
    {
        [TestMethod]
        public void GetRootPathTest()
        {
            Assert.AreEqual(System.IO.Path.GetPathRoot(System.Environment.SystemDirectory), GetRootPath());
        }
    }
}
