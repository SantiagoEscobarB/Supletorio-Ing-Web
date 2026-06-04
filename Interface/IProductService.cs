using Supletorio_Ing_Web.Models;
using Supletorio_Ing_Web.Models.DTO;
using Supletorio_Ing_Web.Service;

namespace Supletorio_Ing_Web.Interface
{
    public interface IProductService
    {
        Task<Productos> create(ProductoDTO producto);
        Task<List<Productos>> getAll();
        Task<Productos> getById(Guid id);
    }
}
