using WebLabParking.Entities;

namespace WebLabParking.DAL.Abstract
{
    public interface IClientRepository :IGenericRepository<Client>
    {
        Client Read(string name);
    }
}