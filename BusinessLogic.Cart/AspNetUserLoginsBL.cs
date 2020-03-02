using Entities.Cart;
using DataAccess.Cart.Repository;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Cart
{
    public class AspNetUserLoginsBL : IAspNetUserLoginsBL
    {
        IAspNetUserLoginsRepository repository;

        public AspNetUserLoginsBL()
        {
            this.repository = new AspNetUserLoginsRepository();
        }
  
        public void Create(AspNetUserLogins entity)
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

        public void Delete(AspNetUserLogins entity)
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

        public IEnumerable<AspNetUserLogins> GetAll()
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

        public AspNetUserLogins GetById(int id)
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

        public AspNetUserLogins GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(AspNetUserLogins entity)
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
