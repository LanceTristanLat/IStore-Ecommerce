using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IStore_Ecommerce.Models
{
    public class Item
    {
        [Key]
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string ProductName { get; set; }
        public string Code { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Required.")]
        public decimal ProductPrice { get; set; }
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        public int CatId { get; set; }
        [Display(Name = "Categories")]
        public Categories Categories { get; set; }
        public int Available { get; set; }

    }
    public enum Categories
    {
        Earphones = 1,
        Macbooks = 2,
        Iphones = 3,
        AppleWatch = 4
    }
}
