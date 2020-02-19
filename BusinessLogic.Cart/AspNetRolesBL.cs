using Entities.Cart;
using Entities.Cart.Repository;
using System;
using System.Collections.Generic;

namespace BusinessLogic.Cart
{
    public class AspNetRolesBL : IAspNetRolesBL
    {
        IAspNetRolesRepository repository;
      
        public AspNetRolesBL()
        {
            this.repository = new AspNetUserRepository();
        }
        public void Create(AspNetRoles entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(AspNetRoles entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AspNetRoles> GetAll()
        {
            throw new NotImplementedException();
        }

        public AspNetRoles GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(AspNetRoles entity)
        {
            throw new NotImplementedException();
        }
    }
}
