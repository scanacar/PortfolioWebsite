using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        public void Delete(T parameter)
        {
            //Context context = new Context();
            using var context = new Context();
            context.Remove(parameter);
            context.SaveChanges();
        }

        public T getById(int id)
        {
            using var context = new Context();

            return context.Set<T>().Find(id);
        }

        public List<T> getList()
        {
            using var context = new Context();

            return context.Set<T>().ToList();
        }

        public void Insert(T parameter)
        {
            using var context = new Context();
            context.Add(parameter);
            context.SaveChanges();
        }

        public void Update(T parameter)
        {
            using var context = new Context();
            context.Update(parameter);
            context.SaveChanges();
        }
    }
}
