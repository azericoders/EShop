using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace EShop.Web.Models
{
    public class CreateProductViewModel
    {

        public CreateProductViewModel()
        {
            AddingDate = DateTime.Now;
        }

        //<Summary>
        //Fields...
        //</Summary>

        public Guid ProductId { get; set; }

        [DisplayName("Malın kodu")]
        public string ProductNumber { get; set; }

        [DisplayName("Ad")]
        [Required(ErrorMessage = "*")]
        public string Name { get; set; }

        [DisplayName("Mövzusu(predmeti)")]
        [Required(ErrorMessage = "*")]
        public string Description { get; set; }

        [DisplayName("Sayı")]
        [Required(ErrorMessage = "*")]
        public int Count { get; set; }

        [DisplayName("Öz qiyməti")]
        [Required(ErrorMessage = "*")]
        public decimal Price { get; set; }

        [DisplayName("Satış qiyməti")]
        [Required(ErrorMessage = "*")]
        public decimal PriceOfBuying { get; set; }

        //[DisplayName("Satış qiyməti")]
        //public string ProductInfo { get; set; }

        public DateTime AddingDate { get; set; }

        [Required(ErrorMessage = "*")]
        public Guid CategoryId { get; set; }

        [Required(ErrorMessage = "*")]
        public Guid CompanyId { get; set; }
    }

    public class ImageModel
    {
        public Image Image { get; set; }
        public string ImageName { get; set; }
    }
}