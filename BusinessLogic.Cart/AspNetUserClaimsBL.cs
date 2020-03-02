using Entities.Cart;
using DataAccess.Cart.Repository;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Cart
{
    public class AspNetUserClaimsBL : IAspNetUserClaimsBL
    {
        IAspNetUserClaimsRepository repository;

        public AspNetUserClaimsBL()
        {
            this.repository = new AspNetUserClaimsRepository();
        }
  
        public void Create(AspNetUserClaims entity)
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

        public void Delete(AspNetUserClaims entity)
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

        public IEnumerable<AspNetUserClaims> GetAll()
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

        public AspNetUserClaims GetById(int id)
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

        public AspNetUserClaims GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(AspNetUserClaims entity)
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
