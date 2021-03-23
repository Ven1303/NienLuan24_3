using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class CategoryTranslation
    {
        public string Id { get; set; }
        public int CategoryId { set; get; }
        public string Name { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string LangueId { set; get; }
        public string SeoAlias { get; set; }
    }
}
