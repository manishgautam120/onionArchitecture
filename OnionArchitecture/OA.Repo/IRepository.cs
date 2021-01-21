using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Repo
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);
    }
}
