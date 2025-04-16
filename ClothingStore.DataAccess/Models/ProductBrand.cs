using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStore.DataAccess.Models.ProductModel;
using ClothingStore.DataAccess.Shared.Classess;

namespace ClothingStore.DataAccess.Models
{
    public class ProductBrand : BaseEntity
    {
        public string Name { get; set; } = null!;
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
