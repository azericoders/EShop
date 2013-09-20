using System;

namespace EShop.Core
{
    public class ProductPhoto
    {
        public Guid ProductPhotoId { get; set; }

        public string Photo { get; set; }

        public string ThumbnailPhoto { get; set; }

        // Fields for relationships

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public bool IsDelete { get; set; }
    }
}