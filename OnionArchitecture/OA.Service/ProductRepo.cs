using OA.Data;
using OA.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service
{
    public class ProductRepo : IProductRepo
    {
        private IRepository<Product> _repository;

        public ProductRepo(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return _repository.GetAll();
        }

        public Product GetProductById(int Id)
        {
            return _repository.GetById(Id);
        }
    }
}

