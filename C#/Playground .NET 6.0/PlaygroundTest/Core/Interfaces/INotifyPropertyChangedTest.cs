using System.ComponentModel;

namespace PlaygroundTest.Core.Interfaces
{
    [TestClass]
    public class INotifyPropertyChangedTest
    {
        [TestMethod]
        public void Test()
        {
            Room room = new Room();
            room.PropertyChanged += (sender, e) =>
            {
                Console.WriteLine($"This changed: {e.PropertyName}");
            };

            Assert.IsNotNull(room);
            room.Name = "Ronnie";
            Assert.AreEqual("Ronnie", room.Name);
            Console.WriteLine(room.Name);
        }
    }

    public class Room : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }
    }
}