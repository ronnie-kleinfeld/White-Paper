namespace PlaygroundTest.Core.Variables
{
    // tuple, record and dictionary entry have default deconstruct method
    [TestClass]
    public class DeconstructTest
    {
        // tuple - has an automatic desconstructor method
        [TestMethod]
        public void Tuple()
        {
            var t1 = (1, 2, 3);

            Assert.AreEqual(1, t1.Item1);
            Assert.AreEqual(2, t1.Item2);
            Assert.AreEqual(3, t1.Item3);

            var (one, two, three) = t1;
            Assert.AreEqual(1, one);
            Assert.AreEqual(2, two);
            Assert.AreEqual(3, three);

            decimal c;
            (_, var b, c) = t1;
            Assert.AreEqual(2, b);
            Assert.AreEqual(3, c);
        }

        // record - has an automatic desconstructor method
        [TestMethod]
        public void Record()
        {
            var h1 = new House(2, 3, 4);

            var (one, two, three) = h1;
            Assert.AreEqual(2, one);
            Assert.AreEqual(3, two);
            Assert.AreEqual(4, three);

            decimal c;
            (_, var b, c) = h1;
            Assert.AreEqual(3, b);
            Assert.AreEqual(4, c);
        }
        private record House(int Room, int Size, int Bath);

        // class - ADD an automatic desconstructor method
        [TestMethod]
        public void Class()
        {
            var p1 = new Planet(4, 5);

            (var desc, var a) = p1;
            Assert.AreEqual("my desc", desc);
            Assert.AreEqual(4, a);

            decimal c;
            (_, var b, c) = p1;
            Assert.AreEqual(4, b);
            Assert.AreEqual(5, c);
        }
        public class Planet
        {
            public int Name { get; set; }
            public int Radius { get; set; }

            public Planet(int name, int radius)
            {
                Name = name;
                Radius = radius;
            }

            public void Deconstruct(out string desc, out int name)
            {
                desc = "my desc";
                name = Name;
            }
            public void Deconstruct(out string desc, out int name, out int radius)
            {
                desc = "my desc";
                name = Name;
                radius = Radius;
            }
        }
    }
}