using rest_dotnet_final.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace rest_dotnet_final.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            return;
        }

        public List<Person> FindByAll()
        {
            List<Person> people = new List<Person>();

            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                people.Add(person);
            }
            return people;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Matheus",
                LastName = "Carvalho",
                Address = "SBC - SP - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name " + i,
                LastName = "Person LastName " + i,
                Address = "Some Address " + i,
                Gender = "Undefined"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
