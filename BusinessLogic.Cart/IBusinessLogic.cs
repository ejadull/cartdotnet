using System.Collections.Generic;

namespace BusinessLogic.Cart
{
    public interface IBusinessLogic<T> where T : class
    {
        ///  
        /// Get All objects  
        ///  
        ///  
        IEnumerable<T> GetAll();
        ///  
        /// Get Object by Id  
        ///  
        ///  
        T GetById(int id);
        ///  
        /// Create the object  
        ///  
        ///  
        void Create(T entity);
        ///  
        /// Delete object  
        ///  
        ///  
        void Delete(T entity);
        ///  
        ///  
        ///  
        ///  
        void Delete(int id);
        ///  
        /// Update the object  
        ///  
        ///  
        void Update(T entity);
    }
}
