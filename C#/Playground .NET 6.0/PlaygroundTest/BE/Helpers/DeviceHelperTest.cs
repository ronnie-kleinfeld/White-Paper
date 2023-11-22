using BE.Helpers;

namespace PlaygroundTest
{
    [TestClass]
    public class DeviceHelperTest
    {
        [TestMethod]
        public void Init()
        {
            Console.WriteLine(DeviceHelper.MachineName);
            Console.WriteLine(DeviceHelper.NewLine);
            Console.WriteLine(DeviceHelper.OsVersion);
            Console.WriteLine(DeviceHelper.UserName);
            Console.WriteLine(DeviceHelper.UserName);
        }
    }
}