namespace BusinessLayer
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person()
        {

        }

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public List<Person> GetPersons()
        {
            return new List<Person>()
            {
                new Person { Name = "alex", Age = 65 },
                new Person { Name = "seb", Age = 34 }
            };
        }
    }
}
