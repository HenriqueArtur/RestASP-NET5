using RestASP_NET5.Model;
using System.Collections.Generic;

namespace RestASP_NET5.Repositoy
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
        bool Exists(long id);
    }
}
