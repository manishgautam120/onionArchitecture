using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int Id);
    }
}
