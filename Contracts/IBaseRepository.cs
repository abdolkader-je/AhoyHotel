﻿using Entities.DataTransferObjects.Commons;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using X.PagedList;

namespace Contracts
{
    public interface IBaseRepository<T>
    {

        Task<IList<T>> GetAll(
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
         );
        Task<IPagedList<T>> GetPagedList(
            RequestParams requestParams,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
            );

        Task<T> Get(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task AddAsync(T entity);
        Task Delete(int id);
        void Update(T entity);
    }
}
