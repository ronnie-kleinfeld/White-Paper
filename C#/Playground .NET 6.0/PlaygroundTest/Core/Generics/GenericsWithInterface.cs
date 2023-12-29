namespace PlaygroundTest.Core.Generics
{
    public class MultipleGenericsSample
    {
        public void Sample()
        {
            var c = new Customer
            {
                Id = 7,
                FirstName = "customer",
                LastName = "first",
            };

            var mapper = new CustomerToPersonMapper();
            var p1 = mapper.Map(c);
            var p2 = c.Map<Person>(mapper);
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public T Map<T>(IMapper<Customer, T> mapper)
        {
            return mapper.Map(this);
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public interface IMapper<S, T>
    {
        T Map(S source);
    }
    public class CustomerToPersonMapper : IMapper<Customer, Person>
    {
        public Person Map(Customer source)
        {
            return new Person
            {
                Id = source.Id,
                FirstName = source.FirstName,
                LastName = source.LastName
            };
        }
    }
}
