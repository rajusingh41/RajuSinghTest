using System;
using System.ComponentModel.DataAnnotations;

namespace SPA.BusinessLib
{
    public class MedicineEntity
    {

        /// <summary>
        /// Medicine full name
        /// </summary>
        [Required]
        public string FullName { get; set; }
        /// <summary>
        /// Medicine brand name
        /// </summary>
        [Required]
        public string BrandName { get; set; }
        /// <summary>
        /// Medicine price
        /// </summary>
        [Required]
        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Price can't have more than 2 decimal places")]
        public decimal Price { get; set; }
        /// <summary>
        /// Quantity of medicine
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public long Quantity { get; set; }

        /// <summary>
        /// Expriry date of medicine
        /// </summary>
        [Required]
        public DateTime Expriry { get; set; }

        /// <summary>
        ///  Remarks about medicine
        /// </summary>
        public string Notes { get; set; }
    }
}
