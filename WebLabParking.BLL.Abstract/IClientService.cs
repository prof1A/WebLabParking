using WebLabParking.Entities;
using WebLabParking.Models;

namespace WebLabParking.BLL.Abstract
{
    public interface IClientService:IServiceGeneric<ClientDTO>
    {
        ClientDTO Read(string name);
    }
}