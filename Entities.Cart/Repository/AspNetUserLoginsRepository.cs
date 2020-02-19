using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;

namespace Entities.Cart.Repository
{
    public class AspNetUserLoginsRepository : IAspNetUserLoginsRepository
    {
        CartWebEntities context;
        public AspNetUserLoginsRepository()
        {
            this.context = new CartWebEntities();
        }
 
        public void Create(AspNetUserLogins entity)
        {
            try
            {
                context.AspNetUserLogins.Add(entity);
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
#if DEBUG
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                            ve.PropertyName,
                            eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                            ve.ErrorMessage);
                    }
#endif
                }
                throw e;
            }
        }

        public void Delete(AspNetUserLogins entity)
        {
            try
            {
                context.AspNetUserLogins.Remove(entity);
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                var entity = context.AspNetUserLogins.Find(id);
                context.AspNetUserLogins.Remove(entity);
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<AspNetUserLogins> GetAll()
        {
            try
            {
                var result = new List<AspNetUserLogins>();

                result = context.AspNetUserLogins.ToList();

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public AspNetUserLogins GetById(int id)
        {
            try
            {
                AspNetUserLogins result = null;
                result = context.AspNetUserLogins.Find(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(AspNetUserLogins entity)
        {
            try
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
