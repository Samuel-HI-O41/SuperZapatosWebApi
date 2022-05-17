using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperZapatos.WinForms.Models
{
    public class ArticleRequest
    {
        public List<Article> stores { get; set; }
        public bool success { get; set; }
        public int total_elements { get; set; }
        public string error_msg { get; set; }
        public int error_code { get; set; }
    }

    public class Article
    {
        public int Id { get; set; }

        public Store Store { get; set; }
        public int StoreId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Total_in_shelf { get; set; }
        public int Total_in_vault { get; set; }
    }
}
