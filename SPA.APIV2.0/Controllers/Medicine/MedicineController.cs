using Newtonsoft.Json;
using SPA.BusinessLib;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;

namespace SPA.APIV2._0
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("api/medicine")]
    public class MedicineController : BaseController
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IReadWriteJson _readWriteJson;
        /// <summary>
        /// 
        /// </summary>
        public MedicineController()
        {
            _readWriteJson = new ReadWriteJson();
        }

        /// <summary>
        /// Get Medicine list
        /// </summary>
        /// <returns></returns>
        [Route("")]
        [HttpGet]
        [ResponseType(typeof(ICollection<MedicineEntity>))]
        public IHttpActionResult Medicines()
        {
            return Ok(_readWriteJson.Read(new MedicineEntity()));
        }

        /// <summary>
        /// Add  Medicine 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("")]
        [HttpPost]
        public IHttpActionResult AddMedicine(MedicineEntity model)
        {
            if (ModelState.IsValid)
            {
                _readWriteJson.Add(model);
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}
