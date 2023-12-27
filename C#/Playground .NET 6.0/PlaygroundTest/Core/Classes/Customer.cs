namespace PlaygroundTest.Core.Classes
{
    public class Customer
    {
        // members
        private int id;
        private string name;
        public DateTime Birthday { get; set; }
        private List<Order> orders;
        private readonly List<Order> orders2 = new List<Order>();
        private Dictionary<string, string> cookies = new Dictionary<string, string>();

        // properties
        public int Id { get; set; }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public List<Order> Orders { get => orders; set => orders = value; }
        public string this[string key]
        {
            get
            {
                return cookies[key];
            }
            set
            {
                cookies[key] = value;
            }
        }


        // calculated properties
        public int Age => (DateTime.Now - Birthday).Days / 365;

        // ctor
        public Customer()
        {
            orders = new List<Order>();
        }
        public Customer(int id) : this()
        {
            this.Id = id;
        }
        public Customer(int id, string name) : this()
        {
            this.Id = id;
            this.Name = name;
        }

        // methods
        public void Call(string name)
        {
        }
        public void Call(int id)
        {
        }
    }
}