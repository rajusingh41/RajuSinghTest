using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPA.BusinessLib
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public interface ICrudService<T> where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        void Add(T model);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        void Update(T model);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        void Delete(T model);


    }
}
