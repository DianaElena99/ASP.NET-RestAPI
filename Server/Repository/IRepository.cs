using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;
using X.PagedList;
using Server.Data;

namespace Server.Repository
{
    interface IRepository <T> where T : class
    {
        Task Insert(T entity);
        Task InsertMany(IList<T> entities);
        void Update(T newEntity);
        Task Delete(int Id);
        Task<T> Get(
           Expression<Func<T, bool>> expression,
           Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
       );
        Task<IList<T>> GetAll(
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
        );

        Task<IPagedList<T>> GetPagedList(
            RequestParams requestParams,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
    }
}
