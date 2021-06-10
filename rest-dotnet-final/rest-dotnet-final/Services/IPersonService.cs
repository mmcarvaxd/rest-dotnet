using rest_dotnet_final.Model;
using System.Collections.Generic;

namespace rest_dotnet_final.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindByAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
