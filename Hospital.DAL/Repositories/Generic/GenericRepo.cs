using Hospital.DAL.Data.Context;
using Hospital.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital.DAL.Repositories.Generic
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly HospitalContext Context;

        public GenericRepo(HospitalContext context)
        {
            Context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().AsNoTracking();
        }
        public T? GetById(Guid id)
        {
            return Context.Set<T>().Find(id);
        }
        public void Add(T entity)
        {
            Context.Add(entity);
        }
        public void Update(T entity)
        {
        }
        public void Delete(T entity)
        {
            Context.Remove(entity);
        }
       
    }
}
