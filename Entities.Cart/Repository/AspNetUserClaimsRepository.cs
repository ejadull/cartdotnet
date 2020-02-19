using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;

namespace Entities.Cart.Repository
{
    public class AspNetUserClaimsRepository : IAspNetUserClaimsRepository
    {
        CartWebEntities context;
        public AspNetUserClaimsRepository()
        {
            this.context = new CartWebEntities();
        }
 
        public void Create(AspNetUserClaims entity)
        {
            try
            {
                context.AspNetUserClaims.Add(entity);
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

        public void Delete(AspNetUserClaims entity)
        {
            try
            {
                context.AspNetUserClaims.Remove(entity);
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
                var entity = context.AspNetUserClaims.Find(id);
                context.AspNetUserClaims.Remove(entity);
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<AspNetUserClaims> GetAll()
        {
            try
            {
                var result = new List<AspNetUserClaims>();

                result = context.AspNetUserClaims.ToList();

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public AspNetUserClaims GetById(int id)
        {
            try
            {
                AspNetUserClaims result = null;
                result = context.AspNetUserClaims.Find(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(AspNetUserClaims entity)
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
