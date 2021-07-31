using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Repository
{
    interface IQueryRepository<IEntity>
    {
        IEntity Get(int Id);
        IList<IEntity> GetAll();
        
    }
}
