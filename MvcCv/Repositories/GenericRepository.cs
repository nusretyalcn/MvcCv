using MvcCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCv.Repositories
{
    public class GenericRepository<T> where T : class,new()
    {
        DbCvEntities db =new DbCvEntities();

        public List<T> GetAll()
        {
            //using (DbCvEntities db = new DbCvEntities())
            //{
                return db.Set<T>().ToList();
           // }    
        }

        public void Add(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public void Delete(T entity)
        {

            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }

        public T Get (int id)
        {
            return db.Set<T>().Find(id);

        }
        public void Update(T entity)
        {
            db.SaveChanges();
        }


    }
}