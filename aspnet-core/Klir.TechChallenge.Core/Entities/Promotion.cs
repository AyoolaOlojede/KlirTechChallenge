using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Core.Entities
{
    public class Promotion : BaseEntity
    {
        public Promotion()
        {
            Products = new List<Product>();
        }
        public string Name { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? DiscountAmount { get; set; }
        public int? MaximumDiscountedQuantity { get; set; }
        public int? QuantityPurchased { get; set; }
        public int? FreeQuantity { get; set; }
        public int LimitationTimes { get; set; }
        public PromotionType PromotionType { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
