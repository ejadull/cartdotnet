using Entities.Cart;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;

namespace DataAccess.Cart.Repository
{
    public class ProductsRepository : IProductsRepository
    {
     
        CartWebEntities context;
        public ProductsRepository()
        {
            this.context = new CartWebEntities();
        }

        public void Create(Products entity)
        {
            try
            {
                context.Products.Add(entity);
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

        public void Delete(Products entity)
        {
            try
            {
                context.Products.Remove(entity);
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
                var entity = context.Products.Find(id);
                context.Products.Remove(entity);
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Products> GetAll()
        {
            try
            {
                var result = new List<Products>();

                result = context.Products.ToList();

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Products GetById(int id)
        {
            try
            {
                Products result = null;
                result = context.Products.Find(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Products GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Products entity)
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
