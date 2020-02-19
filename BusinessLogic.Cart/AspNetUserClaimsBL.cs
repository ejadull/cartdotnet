using Entities.Cart;
using Entities.Cart.Repository;
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
            throw new NotImplementedException();
        }

        public void Delete(AspNetUserClaims entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AspNetUserClaims> GetAll()
        {
            throw new NotImplementedException();
        }

        public AspNetUserClaims GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(AspNetUserClaims entity)
        {
            throw new NotImplementedException();
        }
    }
}
