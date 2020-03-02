﻿using Entities.Cart;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Cart.Repository
{
    public class CategoriesRepository : ICategoriesRepository
    {
     
        CartWebEntities context;
        public CategoriesRepository()
        {
            this.context = new CartWebEntities();
        }

        public void Create(Categories entity)
        {
            try
            {
                context.Categories.Add(entity);
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

        public void Delete(Categories entity)
        {
            try
            {
                context.Categories.Remove(entity);
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
                var entity = context.Categories.Find(id);
                context.Categories.Remove(entity);
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

        public IEnumerable<Categories> GetAll()
        {
            try
            {
                var result = new List<Categories>();

                result = context.Categories.ToList();

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Categories GetById(int id)
        {
            try
            {
                Categories result = null;
                result = context.Categories.Find(id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Categories GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Categories entity)
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
