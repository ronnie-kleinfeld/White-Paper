namespace PlaygroundTest.Core.Variables
{
    [TestClass]
    public class StructTest
    {
        [TestMethod]
        public void Init()
        {
            Location location = new Location(1, 3);
            Assert.IsNotNull(location);
            Assert.AreEqual(1, location.Latitude);
            Assert.AreEqual(3, location.Longitude);
            location.Latitude = 5;
            location.Longitude = 7;
            Assert.IsNotNull(location);
            Assert.AreEqual(5, location.Latitude);
            Assert.AreEqual(7, location.Longitude);
        }
    }

    public struct Location
    {
        // methods
        public int Latitude { get; set; }
        public int Longitude { get; set; }

        public Location(int latitude, int longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        // methods
        public string ToString()
        {
            return $"Latitude={Latitude}, Longitude={Longitude}";
        }
    }
}