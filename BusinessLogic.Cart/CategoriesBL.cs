using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Cart.Repository;
using Entities.Cart;

namespace BusinessLogic.Cart
{
    public class CategoriesBL : ICategoriesBL
    {
        ICategoriesRepository repository;

        public CategoriesBL()
        {
            this.repository = new CategoriesRepository();
        }

        public void Create(Categories entity)
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

        public void Delete(Categories entity)
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

        public IEnumerable<Categories> GetAll()
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

        public Categories GetById(int id)
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

        public Categories GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Categories entity)
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
