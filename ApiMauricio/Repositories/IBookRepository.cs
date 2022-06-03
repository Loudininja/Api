using System.Collections.Generic;
using System.Threading.Tasks;
using ApiMauricio.Model;
using System.Linq;

namespace ApiMauricio.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> Get(int id);
        Task<Book> Create(Book book);
        Task Update(Book book);

        Task Delete(int id);
    }
}
