using Entities.Cart;
using Entities.Cart.Repository;
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
            throw new NotImplementedException();
        }

        public void Delete(AspNetUserLogins entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AspNetUserLogins> GetAll()
        {
            throw new NotImplementedException();
        }

        public AspNetUserLogins GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(AspNetUserLogins entity)
        {
            throw new NotImplementedException();
        }
    }
}
