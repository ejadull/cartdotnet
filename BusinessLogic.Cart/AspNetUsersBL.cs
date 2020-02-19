using Entities.Cart;
using Entities.Cart.Repository;
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
            throw new NotImplementedException();
        }

        public void Delete(AspNetUsers entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AspNetUsers> GetAll()
        {
            throw new NotImplementedException();
        }

        public AspNetUsers GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(AspNetUsers entity)
        {
            throw new NotImplementedException();
        }
    }
}
