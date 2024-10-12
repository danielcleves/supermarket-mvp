using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IProductRepository
    {
        void Add(ProductModel productModel);           // Agregar un nuevo producto
        void Edit(ProductModel productModel);          // Editar un producto existente
        void Delete(int id);                           // Eliminar un producto por ID
        IEnumerable<ProductModel> GetAll();            // Obtener todos los productos
        IEnumerable<ProductModel> GetByValue(string value);  // Buscar productos
    }
}
