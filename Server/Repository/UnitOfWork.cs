using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private GenericRepository<Product> _products;
        private GenericRepository<Store> _stores;
        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public GenericRepository<Product> Products => _products ??= new GenericRepository<Product>(_context);
        public GenericRepository<Store> Stores => _stores ??= new GenericRepository<Store>(_context);


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
