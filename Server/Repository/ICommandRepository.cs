using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Repository
{
    interface ICommandRepository <IEntity>
    {
        void Add(IEntity entity);
        IEntity Update(int Id, IEntity newEntity);
        IEntity Delete(int Id);
    }
}
