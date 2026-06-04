using BackendPolifood.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Supletorio_Ing_Web.Interface;
using Supletorio_Ing_Web.Models;
using Supletorio_Ing_Web.Models.DTO;

namespace Supletorio_Ing_Web.Service
{
    public class ProductsService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductsService(ApplicationDbContext context)
        {
            _context = context;

        }
        public async Task<Productos> create(ProductoDTO dto)
        {
            var producto = new Productos
            {
                Nombre = dto.Nombre,
                Precio = dto.Precio,
                Stock = dto.Stock,
                Descuento = dto.Descuento
            };
            producto.PrecioFinal = producto.Precio * ( 1 - producto.Descuento); //Si el descuento es 30%, es porque el precio es del 70% (1 - 30% = 70%) del precio inicial
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
            return producto;
        }

        public async Task<List<Productos>> getAll()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task<Productos> getById(Guid id)
        {
            return await _context.Productos.Where(p => p.Id == id).FirstOrDefaultAsync();
        }
    }
}
