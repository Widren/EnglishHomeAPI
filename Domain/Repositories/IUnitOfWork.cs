using System.Threading.Tasks;

namespace EnglishHomeAPI.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
