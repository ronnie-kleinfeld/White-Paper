namespace PlaygroundTest.Core.Variables
{
    internal class AnonymousTypes
    {
        public void Usage()
        {
            var myobj = new
            {
                Name = "John Doe",
                Age = 45,
                Address = new
                {
                    Street = "123 Main Street",
                    City = "Anywhere",
                }
            };

            Console.WriteLine($"{myobj.Name}, {myobj.Address.Street}");
            Console.WriteLine($"{myobj}");

            // Anonymous types are read-only and cannot be modified

            // To change a value, use non-destructive mutation and "with" clause
            var myobj2 = myobj with { Name = "Jane Doe" };
            Console.WriteLine($"{myobj2.Name}, {myobj2.Address.Street}");

            // You can check to see if an anonymous object contains a property
            Console.WriteLine($"{myobj.GetType().GetProperty("Name") != null}");
            Console.WriteLine($"{myobj.GetType().GetProperty("Job") != null}");

        }
    }
}