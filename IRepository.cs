using SSTDataAccess;

namespace SSTRepository
{
    public interface IRepository<T> where T : UserBase
    {
        T Get(int id);
    }
}
