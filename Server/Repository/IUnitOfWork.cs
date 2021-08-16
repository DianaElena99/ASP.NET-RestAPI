using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        GenericRepository<Product> Products { get; }
        GenericRepository<Store> Stores { get; }
        Task Save();
    }
}
