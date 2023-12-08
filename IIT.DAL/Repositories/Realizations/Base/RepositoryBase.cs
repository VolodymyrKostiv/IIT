using IIT.DAL.Repositories.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace IIT.DAL.Repositories.Realizations.Base
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected IITDBContext IITDBContext { get; set; }

        protected RepositoryBase(IITDBContext ICHDBContext)
        {
            this.IITDBContext = IITDBContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.IITDBContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.IITDBContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.IITDBContext.Set<T>().Add(entity);
        }

        public async Task CreateAsync(T entity)
        {
            await this.IITDBContext.Set<T>().AddAsync(entity);
        }

        public void Update(T entity)
        {
            this.IITDBContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.IITDBContext.Set<T>().Remove(entity);
        }

        public void Attach(T entity)
        {
            this.IITDBContext.Set<T>().Attach(entity);
        }

        public IQueryable<T> Include(params Expression<Func<T, object>>[] includes)
        {
            IIncludableQueryable<T, object> query = null;

            if (includes.Length > 0)
            {
                query = this.IITDBContext.Set<T>().Include(includes[0]);
            }
            for (int queryIndex = 1; queryIndex < includes.Length; ++queryIndex)
            {
                query = query.Include(includes[queryIndex]);
            }

            return query == null ? this.IITDBContext.Set<T>() : (IQueryable<T>)query;
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            return await this.GetQuery(predicate, include).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, T>> selector, Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            return await this.GetQuery(predicate, include, selector).ToListAsync();
        }

        public async Task<T> GetFirstAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            var query = this.GetQuery(predicate, include);
            return await query.FirstAsync();
        }

        public async Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            return await this.GetQuery(predicate, include).FirstOrDefaultAsync();
        }

        public async Task<T> GetFirstOrDefaultAsync(Expression<Func<T, T>> selector, Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            return await this.GetQuery(predicate, include, selector).FirstOrDefaultAsync();
        }

        public async Task<T> GetLastAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            return await this.GetQuery(predicate, include).LastAsync();
        }

        public async Task<T> GetLastOrDefaultAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            return await this.GetQuery(predicate, include).LastOrDefaultAsync();
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            return await this.GetQuery(predicate, include).SingleAsync();
        }

        public async Task<T> GetSingleOrDefaultAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            return await this.GetQuery(predicate, include).SingleOrDefaultAsync();
        }

        public async Task<Tuple<IEnumerable<T>, int>> GetRangeAsync(
            Expression<Func<T, bool>> predicate = null,
            Expression<Func<T, T>> selector = null,
            Func<IQueryable<T>, IQueryable<T>> sorting = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
            int? pageNumber = null,
            int? pageSize = null)
        {
            return await this.GetRangeQuery(predicate, selector, sorting, include, pageNumber, pageSize);
        }

        private IQueryable<T> GetQuery(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, Expression<Func<T, T>> selector = null)
        {
            var query = this.IITDBContext.Set<T>().AsNoTracking();
            if (include != null)
            {
                query = include(query);
            }
            if (predicate != null)
            {
                query = query.Where(predicate);
            }
            if (selector != null)
            {
                query = query.Select(selector);
            }
            return query;
        }

        private async Task<Tuple<IEnumerable<T>, int>> GetRangeQuery(Expression<Func<T, bool>> filter = null,
                                                       Expression<Func<T, T>> selector = null,
                                                       Func<IQueryable<T>, IQueryable<T>> sorting = null,
                                                       Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
                                                       int? pageNumber = null,
                                                       int? pageSize = null)
        {
            var query = this.IITDBContext.Set<T>().AsNoTracking();

            if (include != null)
            {
                query = include(query);
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (selector != null)
            {
                query = query.Select(selector);
            }

            if (sorting != null)
            {
                query = sorting(query);
            }

            var TotalRecords = await query.CountAsync();

            if (pageNumber != null && pageSize != null)
            {
                query = query.Skip((int)(pageSize * (pageNumber - 1)))
                    .Take((int)pageSize);
            }

            return new Tuple<IEnumerable<T>, int>(query, TotalRecords);
        }
    }
}
