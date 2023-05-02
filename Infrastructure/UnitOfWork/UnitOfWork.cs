using Core.InterFace;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly DataContext _context;
        private IRepository<T> _entity;
        public UnitOfWork(DataContext context)
        {
            _context = context;
        }
        public IRepository<T> Entity
        {
            get
            {
                return _entity ?? (_entity = new Repository<T>(_context));
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
