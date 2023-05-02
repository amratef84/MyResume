using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.InterFace
{
    public interface IUnitOfWork<T> where T : class
    {
        IRepository<T> Entity { get; }
        void Save();
    }
}
