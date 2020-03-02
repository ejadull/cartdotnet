using Entities.Cart;
using DataAccess.Cart.Repository;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Cart
{
    public class AspNetUsersBL : IAspNetUsersBL
    {
        IAspNetUsersRepository repository;

        public AspNetUsersBL()
        {
            this.repository = new AspNetUsersRepository();
        }
 
        public void Create(AspNetUsers entity)
        {
            

            try
            {
                this.repository.Create(entity);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(AspNetUsers entity)
        {
            

            try
            {
                this.repository.Delete(entity);
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
                this.repository.Delete(id);
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

        public IEnumerable<AspNetUsers> GetAll()
        {
            
            try
            {
                return this.repository.GetAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public AspNetUsers GetById(int id)
        {
            try
            {
                return this.repository.GetById(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public AspNetUsers GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(AspNetUsers entity)
        {
            try
            {
                this.repository.Update(entity);
                return;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            
        }
    }
}
