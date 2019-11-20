using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace SPA.BusinessLib
{
    /// <summary>
    /// 
    /// </summary>
    public class ReadWriteJson : IReadWriteJson
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly string jsonFile;
        /// <summary>
        /// 
        /// </summary>
        public ReadWriteJson()
        {
            jsonFile = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.AppSettings["jsonFile"];
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="model"></param>
        public void Add(MedicineEntity model)
        {
            try
            {
                string medicine = JsonConvert.SerializeObject(model, Formatting.Indented);
                var json = File.ReadAllText(jsonFile);
                var jsonObj = JObject.Parse(json);
                var medicinesArrary = jsonObj.GetValue("medicines") as JArray;
                var newMedicine = JObject.Parse(medicine);
                medicinesArrary.Add(newMedicine);
                jsonObj["medicines"] = medicinesArrary;

                string newJsonResult = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
                File.WriteAllText(jsonFile, newJsonResult);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        public void Delete(MedicineEntity model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ICollection<MedicineEntity> Read(MedicineEntity model)
        {
            try
            {
                string json = File.ReadAllText(jsonFile);
                var jObject = JObject.Parse(json);
                JArray experiencesArrary = (JArray)jObject["medicines"];
                return experiencesArrary.ToObject<List<MedicineEntity>>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(MedicineEntity model)
        {
            throw new NotImplementedException();
        }
    }
}
