using ITHS.Webapi.Entities;
using ITHS.Webapi.Persistance;

namespace ITHS.Webapi.Contexts
{
    public class PersonService
    {
        public PersonService()
        {
        }

        public Person GetPerson(Guid id)
        {
            using (var context = new ITHSDatabaseContext())
            {
                var person = context.Persons.Where(p => p.Id == id).FirstOrDefault();

                return person;
            }
        }

        public Person FindPersonsByFirstName(string firstName)
        {
            using (var context = new ITHSDatabaseContext())
            {
                var result = context.Persons
                 .Where(b => b.FirstName.Contains(firstName))
                 .FirstOrDefault();

                return result;
            }
        }

        public void AddPerson(Person person)
        {
            using (var context = new ITHSDatabaseContext())
            {
                context.Persons.Add(person);
                context.SaveChanges();
            }
        }
    }
}
