using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Cart.Repository;
using Entities.Cart;

namespace BusinessLogic.Cart
{
    public class ProductsBL : IProductsBL
    {
     
        IProductsRepository repository;

        public ProductsBL()
        {
            this.repository = new ProductsRepository();
        }

        public void Create(Products entity)
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

        public void Delete(Products entity)
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

        public IEnumerable<Products> GetAll()
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

        public Products GetById(int id)
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

        public Products GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Products entity)
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
