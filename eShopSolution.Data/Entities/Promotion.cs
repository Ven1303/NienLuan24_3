using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Promotion
    {
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string ApplyForAll { get; set; }
        public int DiscountAmount { get; set; }
        public int DiscountPercent { get; set; }
        public int ProductIds { get; set; }
        public string ProductCategoryIds { get; set; }
        public Status Status { get; set; }

    }
}
