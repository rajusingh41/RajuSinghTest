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
   public interface IReadWriteJson: ICrudService<MedicineEntity>
    {
        ICollection<MedicineEntity> Read(MedicineEntity model);
    }
}
